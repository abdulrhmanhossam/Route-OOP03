using Demo.Binding;
using Demo.Overrinding;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binding
            //TypeA RefBase = new TypeB(1, 2);
            //RefBase.A = 11;
            //RefBase.MyMethod01();
            //RefBase.MyMethod02();
            //FullTimeEmployee fullTime = new FullTimeEmployee();
            //ProcessEmployee(fullTime);
            #endregion

            #region Interface

            #endregion

        }

        public static void ProcessEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.MyFun01();
                employee.Myfun02();
            }

        }
    }
}
