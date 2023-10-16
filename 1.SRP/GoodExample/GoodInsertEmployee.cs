using _1.SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SRP.GoodExample
{
    public class GoodInsertEmployee
    {
        public void CreateEmployee(Employee employee)
        {
            StringBuilder builder = new StringBuilder();

            try
            {
                builder.Append(employee.Id);
                builder.AppendLine();
                builder.Append(employee.FirstName);
                builder.AppendLine();
                builder.Append(employee.LastName);
                builder.AppendLine();
                builder.Append(employee.HireDate.ToLongDateString());
                builder.AppendLine();

                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\BadExample\EmployeeData.txt", builder.ToString());
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
