using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Utilidades;

namespace ComparaArquivos
{
	public class ComparacaoArquivos
	{
		private DirectoryInfo dirA;
		private DirectoryInfo dirB;
		private string filtroA = "*.*";
		private string filtroB = "*.*";
		private bool incluiSubPastas = true;
		private int limiteDiferencas = 0;

		#region Construtores

		public ComparacaoArquivos(string arquivoA, string arquivoB, ComparacaoEventHandler OnResultadoComparacao, int limiteDiferencas)
		{
			FileInfo arqA = new FileInfo(arquivoA);
			FileInfo arqB = new FileInfo(arquivoB);
			this.dirA = new DirectoryInfo(arqA.DirectoryName);
			this.dirB = new DirectoryInfo(arqB.DirectoryName);
			this.filtroA = arqA.Name;
			this.filtroB = arqB.Name;
			this.incluiSubPastas = false;
			this.OnResultadoComparacao = OnResultadoComparacao;
		}

		public ComparacaoArquivos(string caminhoA, string caminhoB, bool incluirSubPastas, ComparacaoEventHandler OnResultadoComparacao, int limiteDiferencas)
		{
			this.dirA = new DirectoryInfo(caminhoA);
			this.dirB = new DirectoryInfo(caminhoB);
			this.incluiSubPastas = incluirSubPastas;
			this.OnResultadoComparacao = OnResultadoComparacao;
			this.limiteDiferencas = limiteDiferencas;
		}

		#endregion

		#region Propriedades

		public string FiltroA
		{
			get { return filtroA; }
			set { filtroA = value; }
		}

		public string FiltroB
		{
			get { return filtroB; }
			set { filtroB = value; }
		}

		public bool IncluiSubPastas
		{
			get { return incluiSubPastas; }
			set { incluiSubPastas = value; }
		}

		#endregion

		#region Métodos internos

		private string CaminhoRelativo(string path, string dirBase)
		{
			int p = dirBase.Length;

			if ((p < path.Length) && (path[p] == Path.DirectorySeparatorChar))
				p++;

			return path.Substring(p);
		}

		private bool ArquivosIguais(FileInfo a1, FileInfo a2)
		{
			if (a1.Length != a2.Length)
				return false;

			bool igual = false;

			using (FileStream s1 = a1.OpenRead(), s2 = a2.OpenRead())
			{
				byte[] buffer1 = new byte[1024];
				byte[] buffer2 = new byte[1024];

				while ((s1.Position < s1.Length) && (s2.Position < s2.Length))
				{
					int bytesLidos1 = s1.Read(buffer1, 0, buffer1.Length);
					int bytesLidos2 = s2.Read(buffer2, 0, buffer2.Length);

					if (bytesLidos1 != bytesLidos2)
					{
						igual = false;
						break;
					}
					else
					{
						igual = true;
						int i = 0;

						while ((igual) && (i < bytesLidos1))
						{
							igual = (buffer1[i] == buffer2[i]);
							i++;
						}
					}
				}
			}

			return igual;
		}


		#endregion

		public enum Resultado
		{
			[DescricaoValorEnum("Arquivos com conteúdo diferente")]
			ConteudoDiferente,

			[DescricaoValorEnum("Arquivos que existem apenas no diretório A")]
			UnicoNoDiretorioA,

			[DescricaoValorEnum("Arquivos que existem apenas no diretório B")]
			UnicoNoDiretorioB,

			[DescricaoValorEnum("Arquivos iguais")]
			Igual,
		}

		public delegate void ComparacaoEventHandler(string subpath, string caminhoBase, Resultado comparacao);
		public delegate void ProgressoEventHandler(int valor, int total);

		public event ComparacaoEventHandler OnResultadoComparacao;
		public event ProgressoEventHandler OnProgresso;

		#region Eventos internos

		protected virtual void ResultadoComparacao(string subpath, string caminhoBase, Resultado comparacao)
		{
			if (OnResultadoComparacao != null)
				OnResultadoComparacao(subpath, caminhoBase, comparacao);
		}

		protected virtual void AtualizaProgresso(int valor, int total)
		{
			if (OnProgresso != null)
				OnProgresso(valor, total);
		}

		#endregion

		#region Método de comparação

		public void Comparar()
		{
			if (!dirA.Exists)
				throw new Exception(string.Format("Diretório inválido: '{0}'", dirA.FullName));

			if (!dirB.Exists)
				throw new Exception(string.Format("Diretório inválido: '{0}'", dirB.FullName));

			SearchOption searchOption = ((incluiSubPastas) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
						
			FileInfo[] arquivosA = dirA.GetFiles(filtroA, searchOption);
			FileInfo[] arquivosB = dirB.GetFiles(filtroB, searchOption);

			int totalDiferencas = 0;
			int totalProgresso = (arquivosA.Length + arquivosB.Length);
			int valorProgresso = 0;

			AtualizaProgresso(valorProgresso, totalProgresso);

			// arquivos do diretório A
			foreach (var arqA in arquivosA)
			{				
				if ((limiteDiferencas != 0) && (totalDiferencas >= limiteDiferencas))
					break;

				string subpath = CaminhoRelativo(arqA.FullName, dirA.FullName);
				FileInfo arqB = new FileInfo(Path.Combine(dirB.FullName, subpath));

				if (arqB.Exists)
				{
					if (ArquivosIguais(arqA, arqB))
						ResultadoComparacao(subpath, dirA.FullName, Resultado.Igual);
					else
					{
						ResultadoComparacao(subpath, dirA.FullName, Resultado.ConteudoDiferente);
						totalDiferencas++;
					}
				}
				else
				{
					ResultadoComparacao(subpath, dirA.FullName, Resultado.UnicoNoDiretorioA);
					totalDiferencas++;
				}

				AtualizaProgresso(valorProgresso, totalProgresso);
				valorProgresso++;
			}

			// arquivos do diretório B que não existem no A
			foreach (var arqB in arquivosB)
			{
				if ((limiteDiferencas != 0) && (totalDiferencas >= limiteDiferencas))
					break;

				string subpath = CaminhoRelativo(arqB.FullName, dirB.FullName);
				FileInfo arqA = new FileInfo(Path.Combine(dirA.FullName, subpath));
				
				if (!arqA.Exists)
				{
					ResultadoComparacao(subpath, dirB.FullName, Resultado.UnicoNoDiretorioB);
					totalDiferencas++;
				}

				AtualizaProgresso(valorProgresso, totalProgresso);
				valorProgresso++;
			}

			AtualizaProgresso(totalProgresso, totalProgresso);
		}

		#endregion
	}
}
