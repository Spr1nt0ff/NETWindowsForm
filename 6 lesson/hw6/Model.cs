using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTime
{
    public class Model
    {
        public bool IsPlayerTurn { get; set; } = true;
        public bool IsHardMode { get; set; } = false;
        public Bitmap ImgX { get; set; }
        public Bitmap ImgO { get; set; }

        public Model()
        {
            ImgX = new Bitmap("x.jpg");
            ImgO = new Bitmap("o.jpg");
        }

        public bool CheckWinCondition(Button[] buttons)
        {
            int[,] winSituation = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
            { 0, 4, 8 }, { 2, 4, 6 }
        };


            for (int i = 0; i < winSituation.GetLength(0); i++)
            {
                int first = winSituation[i, 0];
                int second = winSituation[i, 1];
                int third = winSituation[i, 2];

                if (buttons[first].Image == ImgX && buttons[second].Image == ImgX && buttons[third].Image == ImgX)
                {
                    MessageBox.Show("Игрок X победил!");
                    return true;
                }
                else if (buttons[first].Image == ImgO && buttons[second].Image == ImgO && buttons[third].Image == ImgO)
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

            return false;
        }

        public void MakeBotMove(Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                if (btn.Image == null)
                {
                    btn.Image = ImgO;
                    break;
                }
            }
        }
    }
}
