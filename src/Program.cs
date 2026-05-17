namespace productionLine
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);

            ApplicationConfiguration.Initialize();

            loginForm loginWindow = new loginForm();

            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new mainForm());
            }
        }
    }
}