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
        bool bApenasMes = false;

        private void BtnProcura_Click(object sender, EventArgs e)
        {
            AbrirArquivos();
            ArvorePastaArquivo(diretorio);
        }

        private void BtnProcessar_Click(object sender, EventArgs e)
        {
            Processo_Worker.RunWorkerAsync();
        }

        #region Funções

        private void Processar()
        {
            try
            {


                Invoke((Action)(() =>
                {
                    LblProcessando.Text = "Processando...";

                }));


                if (CbCriarAtePastaMes.Checked == false)
                {
                    OrganizarFoto.ListaImagens(diretorio, extensao, bApenasMes);
                }
                else if (CbCriarAtePastaMes.Checked == true)
                {
                    OrganizarFoto.ListaImagens(diretorio, extensao, bApenasMes);
                }


                Invoke((Action)(() =>
                {
                    LblProcessando.Text = "Concluido o processo de organização.";

                }));
                ArvorePastaArquivo(diretorio);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


            try
            {
                Invoke((Action)(() =>
                {
                    tvArvorePasta.Nodes.Clear();
                    if (diretorio != "" && Directory.Exists(strDiretorio))
                    {
                        //Lista arquivos e subpastar no treeview
                        EstruturaPasta.Raiz(strDiretorio, extensao, tvArvorePasta);

                    }
                    else
                    {
                        MessageBox.Show("Selecione uma pasta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }));
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

        private void Processo_Worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
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
    }
}
