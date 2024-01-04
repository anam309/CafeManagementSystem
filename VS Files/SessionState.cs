using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System_2021_CE_1
{
    public static class SessionState
    {
        public static string Username { get; set; }
        public static int CustomerId { get; set; }
        public static int EmployeeId { get; set; }
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-5UN9QJT\SQLEXPRESS;Initial Catalog=cafe_Management_system;Integrated Security=True");
        }
    }
}
