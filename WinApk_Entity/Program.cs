using WinApk_Entity.Entities;

namespace WinApk_Entity
{
    internal static class Program
    {  
        [STAThread]
        static void Main()
        {
            ApkDbContext _dbContext = new ApkDbContext();
            Seeder seed = new Seeder(_dbContext);
            seed.seed();
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.Run(new LoginPanel());
        }
    }
}