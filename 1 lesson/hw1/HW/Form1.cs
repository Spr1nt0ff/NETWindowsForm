namespace HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int date = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            #region task1
            string[] resume = { "ABOUT ME",
                                "I'm a software developer, but my specialty is a website developer.",
                                "I have non-commercial experience in creating websites.",
                                "In general, I can take up my favorite site in terms of complexity," +
                                " we quickly teach you to other languages.",
                                "There is also a good knowledge of OOP and SOLID, And non-commercial experience with software design patterns." };

            for (int i = 0; i < resume.Length; i++)
            {
                date += resume[i].Length;
                MessageBox.Show(resume[i]);
            }

            int average = date / resume.Length;
            MessageBox.Show($"Resume. Average number of characters: {average}", "Resume Summary");

            #endregion

            #region task2
            int min = 1, max = 2000;
            int temp = 0;
            bool check = false;

            while (!check)
            {

                int guess = (min + max) / 2;
                temp++;

                DialogResult result = MessageBox.Show($"Is your number {guess}?",
                    "Guessing Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    MessageBox.Show($"I guessed your number {guess} in {temp} attempts!",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = true;
                }
                else if (result == DialogResult.No)
                {

                    min = guess + 1;
                }
                else if (result == DialogResult.Cancel)
                {

                    max = guess - 1;
                }
            }
            #endregion
        }
    }
}
