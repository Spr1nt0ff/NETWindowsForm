namespace MyTime
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Form1 form = new Form1();
            var model = new Model(); // Модель игры


            var presenter = new Presenter(form, model);


            Application.Run(form);
        }
    }
}