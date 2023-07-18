using hoangpdph31561_CSharp_3_BaiTap_1.View;

namespace hoangpdph31561_CSharp_3_BaiTap_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=QUANLYXEMAY_CS3_XUONG;Integrated Security=True;TrustServerCertificate=true
            //Scaffold-DbContext 'Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=QUANLYXEMAY_CS3_XUONG;Integrated Security=True;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new QuanLyXeMay());
        }
    }
}