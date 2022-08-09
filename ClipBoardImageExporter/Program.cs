namespace ClipBoardImageExporter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Form1 form = new Form1())
            {
                Application.Run();
            }
        }
    }
}