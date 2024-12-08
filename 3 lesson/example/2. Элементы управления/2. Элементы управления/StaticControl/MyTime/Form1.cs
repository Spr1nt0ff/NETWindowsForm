using System.Linq.Expressions;

namespace MyTime
{
    public partial class Form1 : Form
    {
        private bool isPlayerTurn = true;
        private Bitmap imgX;
        private Bitmap imgO;
        private bool isHardMode = false;

        public Form1()
        {
            InitializeComponent();
            imgX = new Bitmap("x.jpg");
            imgO = new Bitmap("o.jpg");

            isHardMode = false;

            radioEasy.Checked = true;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null || btn.Image != null) return;

            if (isPlayerTurn)
            {
                btn.Image = imgX;
                isPlayerTurn = false;

                if (!CheckWinCondition())
                    BotMove();
            }
        }

        private void BotMove()
        {
            if (isHardMode)
            {
                HardModeBotMove();
            }
            else
            {
                EasyModeBotMove();
            }

            CheckWinCondition();
        }

        private void EasyModeBotMove()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && btn.Image == null && btn.Tag?.ToString() == "GameButton")
                {
                    btn.Image = imgO;
                    isPlayerTurn = true;
                    break;
                }
            }
        }

        private void HardModeBotMove()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && btn.Image == null && btn.Tag?.ToString() == "GameButton")
                {
                    btn.Image = imgO;
                    isPlayerTurn = true;
                    break;
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && btn.Tag?.ToString() == "GameButton")
                {
                    btn.Image = null;
                    btn.Enabled = true;
                }
            }

            isPlayerTurn = !checkBot.Checked;

            if (!isPlayerTurn)
            {
                BotMove();
            }
        }

        private bool CheckWinCondition()
        {

         int[,] winSituation = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },  // Горизонтальные линии
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },  // Вертикальные линии
            { 0, 4, 8 }, { 2, 4, 6 }                // Диагонали
        };

                // Массив всех кнопок (предположим, что у вас 9 кнопок)
        Button[] buttons = new Button[] {
            Array1_1, Array1_2, Array1_3, Array2_1, Array2_2, Array2_3, Array3_1, Array3_2, Array3_3
        };

                // Проходим по всем выигрышным комбинациям
                for (int i = 0; i < winSituation.GetLength(0); i++)
                {
                    int first = winSituation[i, 0];
                    int second = winSituation[i, 1];
                    int third = winSituation[i, 2];

                    // Проверяем, что на всех трех кнопках одного типа (X или O)
                    if (buttons[first].Image == imgX && buttons[second].Image == imgX && buttons[third].Image == imgX)
                    {
                        MessageBox.Show("Игрок X победил!");

                        return true;
                    }
                    else if (buttons[first].Image == imgO && buttons[second].Image == imgO && buttons[third].Image == imgO)
                    {
                        MessageBox.Show("Игрок O победил!");
                        return true;
                    }
                }

                bool isDraw = true;
                foreach (Button btn in buttons)
                {
                    if (btn.Image == null)
                    {
                        isDraw = false;
                        break;
                    }
                }

                if (isDraw)
                {
                    MessageBox.Show("Ничья!");
                    return true;
                }

            // Если нет победителя
            return false;
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
                isHardMode = false;
                Console.WriteLine("Выбран легкий режим");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHard.Checked)
            {
                isHardMode = true;
                Console.WriteLine("Выбран сложный режим");
            }
        }
    }
}
