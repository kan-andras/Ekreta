using System.Configuration;
using System.Data;
using System.Windows;

namespace Ekreta
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string dataBase = "eKreta.db";
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
         public static string DataBasePath = System.IO.Path.Combine(path, dataBase);
         public App()
        {
            using (var connection = new SQLite.SQLiteConnection(DataBasePath))
            {
                connection.CreateTable<Models.Diak>();
                connection.CreateTable<Models.Osztaly>();
                connection.CreateTable<Models.Terem>();
                connection.CreateTable<Models.Felhasznalo>();
            }
        }








    }

}
