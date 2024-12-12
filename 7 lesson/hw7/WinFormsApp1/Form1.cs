namespace WinFormsApp1
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += (s, e) => SaveBook?.Invoke(this, EventArgs.Empty);
            button2.Click += (s, e) => DeleteBook?.Invoke(this, EventArgs.Empty);
            get1BookToolStripMenuItem.Click += (s, e) => GetFirstBook?.Invoke(this, EventArgs.Empty);
            deleteAllBooksToolStripMenuItem.Click += (s, e) => DeleteAllBook?.Invoke(this, EventArgs.Empty);
            closePorgramToolStripMenuItem.Click += (s, e) => CloseProgram?.Invoke(this, EventArgs.Empty);
        }

        public string Title => textBox1.Text;
        public string Author => textBox2.Text;
        public string Genre => textBox3.Text;
        public string Year => textBox4.Text;

        public string SelectedBook => listBox1.SelectedItem?.ToString();

        public event EventHandler SaveBook;
        public event EventHandler DeleteBook;
        public event EventHandler GetFirstBook;
        public event EventHandler DeleteAllBook;
        public event EventHandler CloseProgram;

        public void DisplayBooks(List<string> books)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(books.ToArray());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
