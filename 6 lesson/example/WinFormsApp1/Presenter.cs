using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly Model _model;

        public Presenter(IView view, Model model)
        {
            _view = view;
            _model = model;

            _view.SaveBook += OnSaveBook;
            _view.DeleteBook += OnDeleteBook;

            LoadBooks();
        }

        private void OnSaveBook(object sender, EventArgs e)
        {
            _model.Title = _view.Title;
            _model.Author = _view.Author;
            _model.Genre = _view.Genre;
            _model.Year = _view.Year;
            _model.SaveToFile();
            LoadBooks();
        }

        private void OnDeleteBook(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_view.SelectedBook))
            {
                _model.DeleteFromFile(_view.SelectedBook);
                LoadBooks();
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadBooks()
        {
            var books = _model.GetAllBooks();
            _view.DisplayBooks(books);
        }
    }
}
