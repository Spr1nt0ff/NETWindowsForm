using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public interface IView
    {
        string Title { get; }
        string Author { get; }
        string Genre { get; }
        string Year { get; }
        string SelectedBook { get; }
        void DisplayBooks(List<string> books);
        event EventHandler SaveBook;
        event EventHandler DeleteBook;
    }
}
