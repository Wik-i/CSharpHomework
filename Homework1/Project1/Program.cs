using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.Write("mathmatical error ! the number is divided by 0\n");
                    }
                    break;
                
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();
                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))//如果转换成功 数据将放在cleanNum1中 如果转换失败 则返回0
                {
                    Console.Write("This is not valid input. Please enter a valid number: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();
                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter a valid number: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\t+    - Add");
                Console.WriteLine("\t-    - Subtract");
                Console.WriteLine("\t*    - Multiply");
                Console.WriteLine("\t/    - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();
                op = op.Trim();//去掉空格
                while(op != "+" && op != "-" && op != "*" && op != "/")
                {
                    //operation input invalid
                    Console.Write("opration input is invalid ! \n please select again from the four operations:");
                    op = Console.ReadLine();
                    op = op.Trim();
                }
                

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'q' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "q") { endApp = true; }

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}
