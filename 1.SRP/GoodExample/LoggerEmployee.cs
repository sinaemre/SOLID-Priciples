using _1.SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SRP.GoodExample
{
    public class LoggerEmployee
    {
        public void CreateLog(int employeeId)
        {
            StringBuilder builder = new StringBuilder();
            try
            {
                builder = new StringBuilder();
                builder.Append("Kayıt Tarihi: ");
                builder.Append(DateTime.Now);
                builder.Append(employeeId);
                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\BadExample\EmployeeLog.txt", builder.ToString());
            }
			catch (Exception ex) 
			{
                builder = new StringBuilder();
                builder.Append(ex.Message);
                builder.Append(DateTime.Now);
                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\BadExample\EmployeeLog.txt", builder.ToString());
			}
        }
    }
}
