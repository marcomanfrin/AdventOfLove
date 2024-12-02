using System.Collections.Generic;
using System.IO;
using System;
using System.Windows.Forms;

namespace AdventOfLove
{
    public partial class FormCit : Form
    {
        public FormCit(int day)
        {
            Dictionary<int, string> texts = new Dictionary<int, string>();
            texts = LoadText();

            Cit.Text = texts[day];
        }

        public Dictionary<int, string> LoadText()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            string filePath = "testi.txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            int key = int.Parse(parts[0].Trim());
                            string value = parts[1].Trim();
                            dictionary.Add(key, value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la lettura del file: {ex.Message}");
            }
            return dictionary;
        }
    }
}
