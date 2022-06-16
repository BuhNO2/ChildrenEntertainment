using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Users;

namespace Kids
{
    class variables
    {
        public static CurrentUser user = new CurrentUser();
        public static MySqlConnection Connection;
        public static string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ChildEntertain\Server");

    }
}
