using System;

namespace EmployeeWageUC7
{
    class Program
    {

        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int Emp_Wage_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20; 
        public const int Max_Hours_Per_Month = 100;
    public static int ComputeEmpWage()
    {
        int EmpHours = 0, Totalworkhrs = 0, totalworkingdays = 0;
        while (Totalworkhrs <= Max_Hours_Per_Month && totalworkingdays < Num_Of_Working_Days)
        {
            Random ran = new Random();
            int Empcheck = ran.Next(0, 3);
            switch (Empcheck)
            {
                case 1:
                    Console.WriteLine("PART TIME");
                    EmpHours = 4;
                    break;

                case 2:
                    Console.WriteLine("FULL TIME");
                    EmpHours = 8;
                    break;
                default:
                    Console.WriteLine("ABSENT");
                    EmpHours = 0;
                    break;

            }
            totalworkingdays++;
            Totalworkhrs += EmpHours;
            Console.WriteLine("Day#:" + totalworkingdays + "Emp Hrs :" + EmpHours);
        }

        int  TotalEmpwage =Totalworkhrs * Emp_Wage_Per_Hour;
        Console.WriteLine("TOTAL WAGES =" + TotalEmpwage);
        return TotalEmpwage;

    }


        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}
