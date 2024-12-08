namespace homework
{
    public partial class Form1 :Form {
        public Form1()
        {
            InitializeComponent();

            // Настройка размеров окна
            this.Width = 500;
            this.Height = 400;

            // Настройка размеров и расположения метки
            label1.Width = this.ClientSize.Width - 20;
            label1.Height = this.ClientSize.Height - 20;
            label1.Location = new Point(10, 10);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Отображение координат курсора
            Text = $"X = {e.X}, Y = {e.Y}";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Отображение текущих размеров формы
                Text = $"{this.Width} x {this.Height}";
            }
            else if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Вы нажали снаружи прямоугольника");
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            // Определение границ прямоугольника
            bool isOnLeftEdge = e.Location.X == 0;
            bool isOnTopEdge = e.Location.Y == 0;
            bool isOnRightEdge = e.Location.X == label1.Width - 1;
            bool isOnBottomEdge = e.Location.Y == label1.Height - 1;

            // Проверка нажатия на границу
            if (e.Button == MouseButtons.Left && (isOnLeftEdge || isOnTopEdge || isOnRightEdge || isOnBottomEdge))
            {
                MessageBox.Show("Вы нажали на границу прямоугольника");
            }
            else if (e.Button == MouseButtons.Left)
            {
                // Нажатие внутри прямоугольника
                MessageBox.Show($"Вы нажали внутри прямоугольника\n" +
                                $"Mouse: X: {e.Location.X}, Y: {e.Location.Y}\n" +
                                $"Square: W: {label1.Width}, H: {label1.Height}");
            }
        }
    }
}
