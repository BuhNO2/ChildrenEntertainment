using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kids
{
    class DataBase
    {
        public bool ExecuteCommand(MySqlCommand command)
        {
            bool b1 = true;
            try
            {
                variables.Connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception x) { MessageBox.Show(x.ToString()); b1 = false; }
            if (variables.Connection.State == ConnectionState.Open)
                variables.Connection.Close();
            return b1;

        }

    }
}
