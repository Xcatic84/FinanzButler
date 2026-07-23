using FinanzButler.Infrastructure.Data;

namespace FinanzButler.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseInitializer.Initialisieren();

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new HauptFenster());
        }
    }
}