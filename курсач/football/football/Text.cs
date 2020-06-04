using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace football
{
    class Text
    {
        private static string way;
        private static string way2 = "../../../files/copy/temp.txt";
        private string output;

        public Text()
        {
            output = "Информация отсутствует.";
        }

        public Text(string wayy)
        {
            way = wayy;
        }

        public static void AddText(string input)
        {
                using (StreamWriter sw = new StreamWriter(way, true))
                {
                    sw.WriteLine(input);
                }
        }

        public static void DeleteStr(int line_to_delete)
        {
            string line = null;
            int line_number = 0;

                using (StreamReader reader = new StreamReader(way))
                {
                    using (StreamWriter writer = new StreamWriter(way2))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            line_number++;

                            if (line_number == line_to_delete)
                                continue;

                            writer.WriteLine(line);
                        }
                    }
                }
                using (StreamReader reader = new StreamReader(way2))
                {
                    using (StreamWriter writer = new StreamWriter(way))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
                File.Delete(way2);
        }

        public override string ToString()
        {
            output = null;
                using (StreamReader sr = new StreamReader(way))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        output += line + "\n";
                    }
                }
            return output;
        }

    }
}
