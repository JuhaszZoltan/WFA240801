namespace WFA240801
{
    internal static class Program
    {
        internal static string connstr =
            "SERVER = (localdb)\\MSSQLLocalDB; " +
            "DATABASE = teszt;";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmDBBev());
        }
    }
}