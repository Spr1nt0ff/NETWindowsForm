using System.Linq.Expressions;

namespace MyTime
{
    public partial class Form1 : Form, IView
    {
        private Presenter _presenter;


        private Button[] Buttons;

        public Form1()
        {
            InitializeComponent();


            Buttons = new Button[]
            {
                Array1_1, Array1_2, Array1_3, Array2_1, Array2_2, Array2_3, Array3_1, Array3_2, Array3_3
            };
            var model = new Model();
            _presenter = new Presenter(this, model);

            radioEasy.Checked = true;
            _presenter.OnModeChanged(false);
        }

        public void UpdateButtonImage(Button btn, Image img)
        {
            btn.Image = img;
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void EnableButton(Button btn)
        {
            btn.Enabled = true;
        }

        public void DisableButton(Button btn)
        {
            btn.Enabled = false;
        }


        public Button[] GetButtons()
        {
            return Buttons;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                _presenter.OnButtonClick(btn);
            }
        }

        

        private void Start_Click(object sender, EventArgs e)
        {
            _presenter.OnStartGame();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEasy.Checked)
            {
                _presenter.OnModeChanged(false);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHard.Checked)
            {
                _presenter.OnModeChanged(true);
            }
        }
    }
}
