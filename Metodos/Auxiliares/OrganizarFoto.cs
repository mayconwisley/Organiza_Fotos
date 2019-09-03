using System;
using System.Collections.Generic;
using System.IO;

namespace Metodos.Auxiliares
{
    public class OrganizarFoto : OrganizaBase
    {
        public static void ListaImagens(string strDiretorio, String[] extensao, bool apenasMes = false, bool opcExtra = true)
        {
            List<string> lstArquivo = new List<string>();

            foreach (var item in extensao)
            {
                lstArquivo.AddRange(Directory.GetFiles(strDiretorio, string.Format("*.{0}", item)));
            }
            Organizar(strDiretorio, lstArquivo, apenasMes, opcExtra);
        }
    }
}
