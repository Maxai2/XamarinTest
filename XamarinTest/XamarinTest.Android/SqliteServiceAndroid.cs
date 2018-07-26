using System.IO;
using XamarinTest.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqliteServiceAndroid))]
namespace XamarinTest.Droid
{
    public class SqliteServiceAndroid : ISqliteService
    {
        public string GetDbPath(string dbName)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(docsPath, dbName);
            return path;
        }
    }
}