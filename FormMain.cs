using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Utilidades;

namespace ComparaArquivos
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();

		}

		private bool SelecionarCaminho(ref string caminho)
		{
			using (FolderBrowserDialog dlgAbrir = new FolderBrowserDialog())
			{
				dlgAbrir.SelectedPath = caminho;
				dlgAbrir.ShowNewFolderButton = false;

				if (dlgAbrir.ShowDialog() == DialogResult.OK)
				{
					caminho = dlgAbrir.SelectedPath;
					return true;
				}
				else
					return false;
			}
		}

		private bool SelecionarArquivo(ref string caminho, ref string arquivo)
		{
			using (OpenFileDialog dlgAbrir = new OpenFileDialog())
			{
				dlgAbrir.Title = "Selecionar Arquivo...";
				dlgAbrir.InitialDirectory = caminho;
				dlgAbrir.FileName = System.IO.Path.Combine(caminho, arquivo);

				if (dlgAbrir.ShowDialog() == DialogResult.OK)
				{
					caminho = System.IO.Path.GetDirectoryName(dlgAbrir.FileName);
					arquivo = System.IO.Path.GetFileName(dlgAbrir.FileName);
					return true;
				}
				else
					return false;
			}
		}

		private void btnSelecionarCaminhoA_Click(object sender, EventArgs e)
		{
			string caminho = txtCaminhoA.Text;

			if (SelecionarCaminho(ref caminho))
			{
				txtCaminhoA.Text = caminho;

				if (!txtFiltroA.Text.Contains("*"))
					txtFiltroA.Text = "*.*";
			}
		}

		private void btnSelecionarCaminhoB_Click(object sender, EventArgs e)
		{
			string caminho = txtCaminhoB.Text;

			if (SelecionarCaminho(ref caminho))
			{
				txtCaminhoB.Text = caminho;

				if (!txtFiltroB.Text.Contains("*"))
					txtFiltroB.Text = "*.*";
			}
		}

		private void btnSelecionarArquivoA_Click(object sender, EventArgs e)
		{
			string caminho = txtCaminhoA.Text;
			string arquivo = txtFiltroA.Text;

			if (SelecionarArquivo(ref caminho, ref arquivo))
			{
				txtCaminhoA.Text = caminho;
				txtFiltroA.Text = arquivo;
			}
		}

		private void btnSelecionarArquivoB_Click(object sender, EventArgs e)
		{
			string caminho = txtCaminhoB.Text;
			string arquivo = txtFiltroB.Text;

			if (SelecionarArquivo(ref caminho, ref arquivo))
			{
				txtCaminhoB.Text = caminho;
				txtFiltroB.Text = arquivo;
			}
		}

		private void btnComparar_Click(object sender, EventArgs e)
		{
			DirectoryInfo dirA = new DirectoryInfo(txtCaminhoA.Text.Trim());
			DirectoryInfo dirB = new DirectoryInfo(txtCaminhoB.Text.Trim());

			if (!dirA.Exists)
			{
				MessageBox.Show("Caminho A inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				btnSelecionarCaminhoA.Focus();
				return;
			}

			if (!dirB.Exists)
			{
				MessageBox.Show("Caminho B inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				btnSelecionarCaminhoB.Focus();
				return;
			}

			string filtroA = txtFiltroA.Text.Trim();
			string filtroB = txtFiltroB.Text.Trim();

			if (string.IsNullOrEmpty(filtroA))
			{
				MessageBox.Show("Filtro A inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtFiltroA.Focus();
				return;
			}

			if (string.IsNullOrEmpty(filtroB))
			{
				MessageBox.Show("Filtro B inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtFiltroB.Focus();
				return;
			}

			/*if (cboTipoComparacao.SelectedItem == null)
			{
				MessageBox.Show("Escolha o tipo de comparação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cboTipoComparacao.Focus();
				return;
			}*/

			try
			{
				Cursor = Cursors.WaitCursor;
				tvwDiferencas.Nodes.Clear();
				string caminhoA = txtCaminhoA.Text.Trim();
				string caminhoB = txtCaminhoB.Text.Trim();
				int limite = (chkPararAposNDiferencas.Checked) ? int.Parse(txtNDiferencas.Text) : 0;

				ComparacaoArquivos comparador = new ComparacaoArquivos(caminhoA, caminhoB, chkIncluiSubDir.Checked, new ComparacaoArquivos.ComparacaoEventHandler(comparador_OnResultadoComparacao), limite);

				comparador.FiltroA = filtroA;
				comparador.FiltroB = filtroB;
				comparador.OnProgresso += new ComparacaoArquivos.ProgressoEventHandler(comparador_OnProgresso);

				comparador.Comparar();
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		void comparador_OnResultadoComparacao(string subpath, string caminhoBase, ComparacaoArquivos.Resultado comparacao)
		{
			lblVerificandoArquivo.Text = subpath;
			lblVerificandoArquivo.Refresh();

			if ((comparacao == ComparacaoArquivos.Resultado.Igual) &&  (!chkMostrarArquivosIguais.Checked))
				return;

			AdicionaNodeArquivo(subpath, caminhoBase, comparacao);
		}

		void comparador_OnProgresso(int valor, int total)
		{
			if (prgProgresso.Maximum != total)
				prgProgresso.Maximum = total;

			prgProgresso.Value = Math.Min(valor, total);
			prgProgresso.Refresh();
		}

		private void AdicionaNodeArquivo(string subpath, string dirBase, ComparacaoArquivos.Resultado dif)
		{
			string raiz = dif.ToString();
			Color cor = tvwDiferencas.ForeColor;

			switch (dif)
			{
				case ComparacaoArquivos.Resultado.Igual:
					cor = Color.DarkGreen;
					break;
				case ComparacaoArquivos.Resultado.ConteudoDiferente:
					cor = Color.Red;
					break;
				case ComparacaoArquivos.Resultado.UnicoNoDiretorioA:
					cor = lblCaminhoA.ForeColor;
					break;
				case ComparacaoArquivos.Resultado.UnicoNoDiretorioB:
					cor = lblCaminhoB.ForeColor;
					break;
			}

			if (chkAgrupar.Checked)
				CriarNodeRaiz(dif);
			else
			{
				raiz = ".";
				if (!tvwDiferencas.Nodes.ContainsKey(raiz))
				{
					TreeNode nRaiz = tvwDiferencas.Nodes.Add(raiz, "Todos os Arquivos        ");
					nRaiz.NodeFont = new Font(tvwDiferencas.Font, FontStyle.Bold);
					nRaiz.Text = nRaiz.Text.TrimEnd();
				}
			}

			string dir = Path.Combine(raiz, subpath);
			TreeNode n = NodeCaminho(dir);
			
			n.ForeColor = cor;
			n.Tag = dif;

			if ((n.Parent != null) && (!n.Parent.IsExpanded))
				n.Parent.Expand();
			
			tvwDiferencas.Refresh();
		}
		
		
		private void CriarNodeRaiz(ComparacaoArquivos.Resultado cmp)
		{
			EnumInfo<ComparacaoArquivos.Resultado> e = new EnumInfo<ComparacaoArquivos.Resultado>(cmp);

			if (!tvwDiferencas.Nodes.ContainsKey(e.Nome))
			{
				int i = 0;
				
				foreach (TreeNode x in tvwDiferencas.Nodes)
				{
					EnumInfo<ComparacaoArquivos.Resultado> z = new EnumInfo<ComparacaoArquivos.Resultado>(x.Name);

					if (e.Valor > z.Valor)
						i++;
					else
						break;
				}
				
				TreeNode n = tvwDiferencas.Nodes.Insert(i, e.Nome, e.Descricao + "              ");
				n.NodeFont = new Font(tvwDiferencas.Font, FontStyle.Bold);
				n.Text = n.Text.TrimEnd();				
			}
		}

		private TreeNode NodeCaminho(string caminho)
		{
			TreeNodeCollection nodes = tvwDiferencas.Nodes;
			TreeNode node = null;

			foreach (string subdir in caminho.Split(new char[] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries))
			{
				if (nodes.ContainsKey(subdir))
					node = nodes[subdir];
				else
					node = nodes.Add(subdir, subdir);

				nodes = node.Nodes;
			}

			return node;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			chkPararAposNDiferencas_CheckedChanged(sender, e);

			//spcDiferencas.Paint += new PaintEventHandler(spcDiferencas_Paint);
		}

		//void spcDiferencas_Paint(object sender, PaintEventArgs e)
		//{
		//	int x = spcDiferencas.SplitterRectangle.Left + (spcDiferencas.SplitterRectangle.Width / 2);
		//	int y1 = spcDiferencas.Panel1.ClientRectangle.Top;
		//	int y2 = spcDiferencas.Panel1.ClientRectangle.Bottom;

		//	e.Graphics.DrawLine(new Pen(SystemColors.ControlDark, 1), x, y1, x, y2);
		//}

		private void formPlacement_OnLerValores(object sender, Componentes.FormPlacement.LerEventArgs e)
		{
			txtCaminhoA.Text = e.LerString("CaminhoA", txtCaminhoA.Text);
			txtCaminhoB.Text = e.LerString("CaminhoB", txtCaminhoB.Text);
			txtFiltroA.Text = e.LerString("FiltroA", txtFiltroA.Text);
			txtFiltroB.Text = e.LerString("FiltroB", txtFiltroB.Text);
			chkIncluiSubDir.Checked = e.LerBoolean("IncluiSubDir", chkIncluiSubDir.Checked);
			spcDiferencas.SplitterDistance = e.LerInt("Diferencas_SplitterDistance", spcDiferencas.SplitterDistance);
			chkPararAposNDiferencas.Checked = e.LerBoolean("ParaAposNDiferencas", chkPararAposNDiferencas.Checked);
			txtNDiferencas.Text = e.LerString("NDiferencas", txtNDiferencas.Text);
			chkMostrarArquivosIguais.Checked = e.LerBoolean("MostrarArquivosIguais", chkMostrarArquivosIguais.Checked);
			chkAgrupar.Checked = e.LerBoolean("MostrarEmGrupos", chkAgrupar.Checked);
		}

		private void formPlacement_OnSalvarValores(object sender, Componentes.FormPlacement.SalvarEventArgs e)
		{
			e.SalvarString("CaminhoA", txtCaminhoA.Text);
			e.SalvarString("CaminhoB", txtCaminhoB.Text);
			e.SalvarString("FiltroA", txtFiltroA.Text);
			e.SalvarString("FiltroB", txtFiltroB.Text);
			e.SalvarBoolean("IncluiSubDir", chkIncluiSubDir.Checked);
			e.SalvarInt("Diferencas_SplitterDistance", spcDiferencas.SplitterDistance);
			e.SalvarBoolean("ParaAposNDiferencas", chkPararAposNDiferencas.Checked);
			e.SalvarString("NDiferencas", txtNDiferencas.Text);
			e.SalvarBoolean("MostrarArquivosIguais", chkMostrarArquivosIguais.Checked);
			e.SalvarBoolean("MostrarEmGrupos", chkAgrupar.Checked);
		}

		private void chkPararAposNDiferencas_CheckedChanged(object sender, EventArgs e)
		{
			txtNDiferencas.Enabled = chkPararAposNDiferencas.Checked;
		}

		private void tvwDiferencas_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node == null)
				return;

			StringBuilder info = new StringBuilder();

			info.AppendLine(e.Node.Text);
			info.AppendLine();

			if (e.Node.Tag != null)
			{
				ComparacaoArquivos.Resultado cmp = (ComparacaoArquivos.Resultado)e.Node.Tag;

				switch (cmp)
				{
					case ComparacaoArquivos.Resultado.ConteudoDiferente:
						info.AppendLine("Conteúdo diferente");
						break;
					case ComparacaoArquivos.Resultado.UnicoNoDiretorioA:
						info.AppendLine("Existe apenas no diretório A");
						break;
					case ComparacaoArquivos.Resultado.UnicoNoDiretorioB:
						info.AppendLine("Existe apenas no diretório B");
						break;
					case ComparacaoArquivos.Resultado.Igual:
						info.AppendLine("Conteúdo igual");
						break;
					default:
						break;
				}

			}

			txtDetalhes.Text = info.ToString();
		}
	}
}