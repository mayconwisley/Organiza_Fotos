using Metodos.Auxiliares;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos.Arquivos
{
    public class EstruturaPastaMover
    {
        public static void Raiz(string diretorio, String[] extensao)
        {
            Arquivos(diretorio, extensao);

        }

        private static void Arquivos(string diretorio, String[] extensao)
        {
            try
            {
                List<string> lstArquivo = new List<string>();
                foreach (var item in extensao)
                {
                    lstArquivo.AddRange(Directory.GetFiles(diretorio, String.Format("*.{0}", item)));
                }

                Diretorios(diretorio, extensao);
                OrganizaArquivo.OrganizarPasta(diretorio, lstArquivo);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private static void Diretorios(string diretorio, String[] extensao)
        {
            string[] subDir = Directory.GetDirectories(diretorio);


            foreach (string item in subDir)
            {
                Diretorios(item, extensao);
                Arquivos(item, extensao);
            }
        }
    }
}
