using System;
using System.Collections.Generic;
using System.IO;

namespace Metodos.Auxiliares
{
    public class OrganizaBase
    {
        static DateTime dt = DateTime.Parse("01/01/0001");

        public static void Organizar(string strDiretorio, List<string> lstArquivo, bool apenasMes = false)
        {
            foreach (string item in lstArquivo)
            {
                string novoDir = string.Empty;
                string moverDir = string.Empty;

                FileInfo fileInfo = new FileInfo(item);
                try
                {
                    dt = DataFoto(item, fileInfo);
                    novoDir = NovoDiretorio(strDiretorio, fileInfo, apenasMes);
                    Directory.CreateDirectory(novoDir);

                    File.Move(item.Trim(), novoDir + @"\" + fileInfo.Name);
                }
                catch (Exception ex)
                {
                    moverDir = strDiretorio + @"\Arquivos Danificados\" + fileInfo.Name;

                    Directory.CreateDirectory(strDiretorio + @"\Arquivos Danificados");
                    File.Move(item.Trim(), moverDir);

                    throw new Exception(ex.Message + "\n\nArquivo(s) Danificado(s) ou em Execução\n\n" +
                                                     "Movido para a pasta\n" +
                                                     moverDir);
                }
            }
        }

        public static void OrganizarPasta(string strDiretorio, List<string> lstArquivo, bool apenasMes = false)
        {
            foreach (string item in lstArquivo)
            {
                string novoDir = string.Empty;
                string moverDir = string.Empty;

                FileInfo fileInfo = new FileInfo(item);
                try
                {
                    dt = DataFoto(item, fileInfo);
                    novoDir = NovoDiretorio(strDiretorio, fileInfo, apenasMes);
                    Directory.CreateDirectory(novoDir);

                    File.Move(item.Trim(), novoDir + @"\" + fileInfo.Name);
                }
                catch (Exception ex)
                {
                    moverDir = strDiretorio + @"\Arquivos Danificados\" + fileInfo.Name;

                    Directory.CreateDirectory(strDiretorio + @"\Arquivos Danificados");
                    File.Move(item.Trim(), moverDir);

                    throw new Exception(ex.Message + "\n\nArquivo(s) Danificado(s) ou em Execução\n\n" +
                                                     "Movido para a pasta\n" +
                                                     moverDir);
                }
            }
        }

        public static DateTime DataFoto(string item, FileInfo fileInfo)
        {

            dt = DataFotoOrigem.DataOrigem(item);

            if (dt.Date == DateTime.Parse("01/01/0001"))
            {
                dt = fileInfo.LastWriteTime;
            }
            return dt;

        }

        public static string NovoDiretorio(string strDiretorio, FileInfo fileInfo, bool apenasMes)
        {
            string novoDir = string.Empty;

            if (apenasMes == false)
            {
                novoDir = strDiretorio + @"\" + dt.ToString("yyyy") + @"\" + dt.ToString("MM_dd");
            }
            else if (apenasMes == true)
            {
                novoDir = strDiretorio + @"\" + dt.ToString("yyyy") + @"\" + dt.ToString("MM");
            }

            return novoDir;
        }
    }
}
