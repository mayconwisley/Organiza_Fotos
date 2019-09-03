using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Metodos.Arquivos
{
    public static class EstruturaPasta
    {

        public static void Raiz(string diretorio, String[] extensao, TreeView treeView = null)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(diretorio);
            TreeNode treeNode = treeView.Nodes.Add(directoryInfo.Name);
            treeNode.Tag = directoryInfo.FullName;
            treeNode.ImageIndex = 1;
            Arquivos(diretorio, extensao, treeNode);
            Diretorios(diretorio, extensao, treeNode);
        }

        private static void Arquivos(string diretorio, String[] extensao, TreeNode tNode = null)
        {
            try
            {
                List<string> lstArquivo = new List<string>();
                foreach (var item in extensao)
                {
                    lstArquivo.AddRange(Directory.GetFiles(diretorio, String.Format("*.{0}", item)));
                }

                foreach (string item in lstArquivo)
                {
                    FileInfo fileInfo = new FileInfo(item);
                    TreeNode treeNode = tNode.Nodes.Add(fileInfo.Name);
                    treeNode.Tag = fileInfo.FullName;
                    treeNode.ImageIndex = 0;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private static void Diretorios(string diretorio, String[] extensao, TreeNode tNode = null)
        {
            string[] subDir = Directory.GetDirectories(diretorio);


            foreach (string item in subDir)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(item);
                TreeNode treeNode = tNode.Nodes.Add(directoryInfo.Name);
                treeNode.ImageIndex = 1;
                treeNode.Tag = directoryInfo.FullName;
                Arquivos(item, extensao, treeNode);
                Diretorios(item, extensao, treeNode);
            }
        }

    }
}
