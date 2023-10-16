using _1.SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SRP.BadExample
{
    public class BadEmployee
    {
        public void CreateEmployee(Employee employee)
        {
            StringBuilder builder = new StringBuilder();
            try
            {
                #region İşlem 1: Çalışanın özlük bilgilerinin kaydedilmesi
                builder.Append(employee.Id);
                builder.AppendLine();
                builder.Append(employee.FirstName);
                builder.AppendLine();
                builder.Append(employee.LastName);
                builder.AppendLine();
                builder.Append(employee.HireDate.ToLongDateString());
                builder.AppendLine();

                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\BadExample\EmployeeData.txt", builder.ToString());
                #endregion

                #region İşlem - 2: Çalışanın sisteme giriş yapması sonucunda doğan logların tutulması
                builder = new StringBuilder();
                builder.Append("Kayıt Tarihi: ");
                builder.Append(DateTime.Now);
                builder.Append(employee.Id);
                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\BadExample\EmployeeLog.txt", builder.ToString());
                #endregion
            }
            catch (Exception ex)
            {
                #region İşlem - 3: Yukarıdaki süreçlerden herhangi birinin gerçekleşmemsi durumunda alınacak hataların tutulması
                builder = new StringBuilder();
                builder.Append(ex.Message);
                builder.Append(DateTime.Now);
                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\BadExample\EmployeeLog.txt", builder.ToString());
                #endregion
            }
        }
    }
}
