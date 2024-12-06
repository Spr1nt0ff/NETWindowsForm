using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Model
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        private const string FilePath = "books.txt";

        public Model()
        {
            Checker();
        }

        private void Checker()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Dispose();
            }
        }

        public void SaveToFile()
        {
            Checker();
            var bookData = $"{Title}|{Author}|{Genre}|{Year}";
            File.AppendAllText(FilePath, bookData + Environment.NewLine);
        }

        public void DeleteFromFile(string bookData)
        {
            Checker();
            List<string> lines = File.ReadAllLines(FilePath).ToList();
            lines.Remove(bookData);

            File.WriteAllLines(FilePath, lines);
        }

        public List<string> GetAllBooks()
        {
            Checker();
            return File.ReadAllLines(FilePath).ToList();
        }
    }
}
