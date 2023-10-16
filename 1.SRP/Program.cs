using _1.SRP.BadExample;
using _1.SRP.Entity;
using _1.SRP.GoodExample;

namespace _1.SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sina Emre", LastName = "Bekar", HireDate = new DateTime(2023, 01, 20) };
            #region Bad
            //BadEmployee saver = new BadEmployee();
            //saver.CreateEmployee(employee);
            #endregion
           
            #region Good
            GoodInsertEmployee goodInsertEmployee = new GoodInsertEmployee();
            goodInsertEmployee.CreateEmployee(employee);

            LoggerEmployee loggerEmployee = new LoggerEmployee();
            loggerEmployee.CreateLog(employee.Id);
            #endregion


        }
    }
}