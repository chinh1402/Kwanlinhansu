using quanlihosonhansu.User__things;
using quanlihosonhansu.Admin__phongban;
using quanlihosonhansu.Authentication;
using quanlihosonhansu.Admin__hosonhansu;
using quanlihosonhansu.Admin__chucvu;

namespace quanlihosonhansu
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
            Application.Run(new frmQLKhachHang());
        }
    }
}