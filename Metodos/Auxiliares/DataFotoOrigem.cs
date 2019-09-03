using System;
using System.Drawing;
using System.Text;

namespace Metodos.Auxiliares
{
    public static class DataFotoOrigem
    {
        private const int DATE_TAKEN_TAG_ID = 0x9003;

        public static DateTime DataOrigem(string file)
        {

            using (Image img = Image.FromFile(file))
            {
                string dataOrigemFoto = null;
                DateTime data = DateTime.Parse("01/01/0001");


                try
                {
                    dataOrigemFoto = Encoding.ASCII.GetString(img.GetPropertyItem(DATE_TAKEN_TAG_ID).Value);

                    string[] parts = dataOrigemFoto.Split(':', ' ');

                    int year = int.Parse(parts[0]);

                    int month = int.Parse(parts[1]);

                    int day = int.Parse(parts[2]);

                    int hour = int.Parse(parts[3]);

                    int minute = int.Parse(parts[4]);

                    int second = int.Parse(parts[5]);

                    return new DateTime(year, month, day, hour, minute, second);
                }
                catch
                {
                    return data;
                }
            }
        }
    }
}
