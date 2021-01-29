using System;
using System.Text;

namespace Calculadora
{
    class Program
    {

        static double Firstvalue;
        static double Secondvalue;
        static int operation;
        static AOperation typeoperation;
        
        #region Main  
        static void Main(string[] args)
        {
            CreateScreen();

            ExecuteOperation();

            ShowOperation();
        }
        #endregion

        #region CreateScreen

        static void CreateScreen()
        {
            Console.WriteLine("Welcome");

            Console.WriteLine("############################");

            Console.WriteLine("Please Write the first value: ");
            Firstvalue = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("Please Write the second value: ");
            Secondvalue = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("Which operation do you want to use?");
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subtraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            operation = Convert.ToInt32(Console.ReadLine() ?? "0");
        }
        #endregion
        static void ExecuteOperation()
        {
            switch ((OperationNumber)operation)
            {
                case OperationNumber.PLUS:
                    typeoperation = new Addition(Firstvalue, Secondvalue);
                    break;

                case OperationNumber.MINUS:
                    typeoperation = new Subtraction(Firstvalue, Secondvalue);
                    break;

                case OperationNumber.CROSS:
                    typeoperation = new Multiplication(Firstvalue, Secondvalue);
                    break;

                case OperationNumber.DIVISION:
                    typeoperation = new Division(Firstvalue, Secondvalue);
                    break;
            }
        }
        static void ShowOperation()
        {
            var operation = new Operations(typeoperation);

            Console.WriteLine("------------------------");

            StringBuilder sb = new StringBuilder()
                           .Append("O resultado é: ")
                           .Append(operation.Equals());
            Console.WriteLine(sb.ToString());

            Console.WriteLine("========================");
        }
    }
}
