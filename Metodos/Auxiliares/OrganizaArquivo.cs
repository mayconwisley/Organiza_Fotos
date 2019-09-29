using System;
using System.Collections.Generic;
using System.IO;

namespace Metodos.Auxiliares
{
    public class OrganizaArquivo : OrganizaBase
    {
        public static void ListaArquivos(string strDiretorio, String[] extensao, bool apenasMes = false)
        {
            List<string> lstArquivo = new List<string>();

            foreach (var item in extensao)
            {
                lstArquivo.AddRange(Directory.GetFiles(strDiretorio, string.Format("*.{0}", item)));
            }
            Organizar(strDiretorio, lstArquivo, apenasMes);
        }
    }
}
