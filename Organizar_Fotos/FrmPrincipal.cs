using Metodos.Arquivos;
using Metodos.Auxiliares;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace Organiza_Fotos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        string diretorio = string.Empty;
        string[] extensao = { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
        string[] tudoext = { "*" };
        bool bOpcExtra = false, bApenasMes = false, opcSubPasta = false;
        int qtdArquivo = 0;

        private void BtnProcura_Click(object sender, EventArgs e)
        {
            AbrirArquivos();
            ArvorePastaArquivo(diretorio);
        }

        private void BtnProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                Processar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        #region Funções

        private void Processar()
        {
            try
            {
                LblProcessando.Text = "Processando...";
                if (opcSubPasta == true)
                {
                    //Reanalizar processo de pastas;
                    //EstruturaPastaMover.Raiz(diretorio, tudoext);
                }
                else
                {

                    if (CbCriarAtePastaMes.Checked == false && CbOpcExtra.Checked == false)
                    {
                        OrganizarFoto.ListaImagens(diretorio, extensao, bApenasMes, bOpcExtra);
                    }
                    else if (CbCriarAtePastaMes.Checked == true && CbOpcExtra.Checked == false)
                    {
                        OrganizarFoto.ListaImagens(diretorio, extensao, bApenasMes, bOpcExtra);
                    }
                    else if ((CbCriarAtePastaMes.Checked == true || CbCriarAtePastaMes.Checked == false) && CbOpcExtra.Checked == true)
                    {
                        OrganizaArquivo.ListaArquivos(diretorio, tudoext, bApenasMes, bOpcExtra);
                    }
                }
                ArvorePastaArquivo(diretorio);
                LblProcessando.Text = "Concluido o processo de organização.";
            }
            catch (Exception ex)
            {
                qtdArquivo++;
                MessageBox.Show(ex.Message + "\n\nQuantidade movido: " + qtdArquivo.ToString(), "Aviso", MessageBoxButtons.OK);
                Processar();
            }
        }


        private void AbrirArquivos()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = txtDiretorio.Text;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                diretorio = folderBrowser.SelectedPath;
                txtDiretorio.Text = diretorio;
            }
        }

        private void ArvorePastaArquivo(string strDiretorio)
        {
            tvArvorePasta.Nodes.Clear();

            try
            {
                if (diretorio != "" && Directory.Exists(strDiretorio))
                {
                    //Lista arquivos e subpastar no treeview
                    if (CbOpcExtra.Checked == true)
                    {
                        EstruturaPasta.Raiz(strDiretorio, tudoext, tvArvorePasta);
                    }
                    else
                    {
                        EstruturaPasta.Raiz(strDiretorio, extensao, tvArvorePasta);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma pasta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void TvArvorePasta_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode treeNode = e.Node;
                PbImagem.ImageLocation = treeNode.Tag.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbCriarAtePastaMes_CheckedChanged(object sender, EventArgs e)
        {
            if (CbCriarAtePastaMes.Checked)
            {
                bApenasMes = true;
            }
            else
            {
                bApenasMes = false;
            }
        }

        private void CbProcessarSubPasta_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opção apenas para Opção Extra", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
            {
                CbOpcExtra.Checked = true;
                bOpcExtra = true;
                opcSubPasta = true;
            }
            else
            {
                opcSubPasta = false;
            }
        }

        private void TvArvorePasta_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode treeNode = e.Node;
                Process.Start(treeNode.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbOpcExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (CbOpcExtra.Checked)
            {
                CbCriarAtePastaMes.Checked = false;
                CbCriarAtePastaMes.Enabled = false;
                bOpcExtra = true;
            }
            else
            {
                CbCriarAtePastaMes.Enabled = true;
                bOpcExtra = false;
            }
        }
    }
}
