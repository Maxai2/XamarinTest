using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTest
{
    public interface ISqliteService
    {
        string GetDbPath(string dbName);
    }
}
