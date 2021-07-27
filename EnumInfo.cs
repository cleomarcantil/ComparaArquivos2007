using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Utilidades
{
	public struct EnumInfo<T> where T : struct
	{
		private T _valor;

		public EnumInfo(T valor)
		{
			this._valor = valor;
		}

		public EnumInfo(string nome)
		{
			if (!string.IsNullOrEmpty(nome))
				this._valor = (T)Enum.Parse(typeof(T), nome);
			else
				this._valor = default(T);
		}

		public T Valor
		{
			get { return _valor; }
		}

		public string Nome
		{
			get { return Valor.ToString(); }
		}

		public string Descricao
		{
			get
			{
				System.Reflection.FieldInfo fi = Valor.GetType().GetField(Valor.ToString());
				DescricaoValorEnumAttribute[] descEnumAttributes = (DescricaoValorEnumAttribute[])fi.GetCustomAttributes(typeof(DescricaoValorEnumAttribute), false);

				string desc = string.Empty;

				if (descEnumAttributes.Length > 0)
					desc = descEnumAttributes[0].Descricao;
				else
				{
					DescriptionAttribute[] descAttributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

					if (descAttributes.Length > 0)
						desc = descAttributes[0].Description;
				}

				return ((!string.IsNullOrEmpty(desc)) ? desc  : Nome);
			}
		}

		public override string ToString()
		{
			return Nome;
		}

		public static IEnumerable<EnumInfo<T>> Valores()
		{
			foreach(object e in Enum.GetValues(typeof(T)))
			{
				yield return new EnumInfo<T>((T)e);
			}
		}

	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DescricaoValorEnumAttribute : Attribute
	{
		private string descricao;

		//public DescricaoEnumAttribute()
		//{
		//}

		public DescricaoValorEnumAttribute(string descricao)
		{
			this.descricao = descricao;
		}

		public virtual string Descricao
		{
			get { return descricao; }
		}

		public override bool Equals(object obj)
		{
			if ((obj != null) && (obj is DescricaoValorEnumAttribute))
				return Descricao.Equals(((DescricaoValorEnumAttribute)obj).Descricao);
			else
				return false;
		}

		public override int GetHashCode()
		{
			return descricao.GetHashCode();
		}
	}
}
