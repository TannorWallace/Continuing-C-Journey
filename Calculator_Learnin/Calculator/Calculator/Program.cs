using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoMaths(double num1, double num2, string op)
        {
            double result = double.NaN;//NaN = not a number

            //again use a Switch statement to do the MATHS! YEW!! LEARNIN'!
            switch(op)
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
                    if (num2 != 0)
                    {
                    result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
        class Program
        {
            static void Main(string[] args)
            {
                bool endApp = false;
                Console.WriteLine("Calculator LEARNIN' C#!! YEWT!!");
                Console.WriteLine("------------------------------/n");

                //while loop that keeps the program running! bool endApp = false;
                while(!endApp)
                {
                    //empty variables 
                    string numInput1 = "";
                    string numInput2 = "";
                    double result = 0;

                    //askinng for first number
                    Console.WriteLine("Enter a numbah! Then hit that ENTAH key!");
                    numInput1 = Console.ReadLine();

                    //idk what this next bit is ...but ill try to work through it.

                    //ok I think that this next line is meant to convert a string into a double value? I think...I mean I get whats its doing but I cant explain it yet.
                    double cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.WriteLine("Eh!? No you need to enter valid input! Try again!");
                        numInput1 = Console.ReadLine();
                    }
                    //asking for SECOND number
                    Console.WriteLine("Enter a another numbah! Then hit that ENTAH key!");
                    numInput2 = Console.ReadLine();

                    //idk what this next bit is ...but ill try to work through it.

                    //ok I think that this next line is meant to convert a string into a double value? I think...I mean I get whats its doing but I cant explain it yet.
                    double cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.WriteLine("Eh!? No you need to enter valid input! Try again!");
                        numInput2 = Console.ReadLine();
                    }
                    //ok now for the switch statement for choices! LEARNIN'! WEWT!!
                    Console.WriteLine("Choose a MATH to do! YOUS!");
                    Console.WriteLine("\t+ - Add");
                    Console.WriteLine("\t- = Subtract");
                    Console.WriteLine("\t* - Multiply");
                    Console.WriteLine("\t\\ - Divide");
                    Console.WriteLine("Your Option!");

                    string op = Console.ReadLine();

                    // ah the good ol try catch ! LEARNIN' REFRESHIN' ABSORBIN'!
                    try
                    {
                        result = Calculator.DoMaths(cleanNum1, cleanNum2, op);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("This Operation a'int MATHS!");
                        }
                        else
                        { 
                        Console.WriteLine("Your result is: {0:0.##}\n", result);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Oh NO! Dems A'INT MATHS!\n -Details" + e.Message);
                    }
                    Console.WriteLine("_______________________________________\n");
                    //feed back to change endApp to == True;
                    Console.Write("Press 'n' and ENTAH to terminate DAH App, or press the ANY key and enter to continue:");
                    if(Console.ReadLine() == "n")
                    {
                        endApp = true;
                    }
                    Console.WriteLine("\n"); //I guess this is friendly?

                    }
                return;
                }
            }
        }
        #region
        /* static void Main(string[] args)
         {
             double num1 = 0; double num2 = 0;

             Console.WriteLine("This is a Calculator...for learnin' C#\r");
             Console.WriteLine("-----------------------------------\n");

             Console.WriteLine("Type in a number and press enter! LEARNIN'!");
                 num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Type a second number and press enter! LEARNIN'! YEW!");
             num2 = Convert.ToDouble(Console.ReadLine());

             //Choosing options 

             Console.WriteLine("Choose and option from the following list:");
             Console.WriteLine("\ta - Add");
             Console.WriteLine("\ts - Subtract");
             Console.WriteLine("\tm - Multiply");
             Console.WriteLine("\td - Divide");
             Console.Write("What is your choice? ");

             //switch statement to handle the maths!! YEW!! LEARNIN!
             switch(Console.ReadLine())
             {
                 case "a":
                     Console.WriteLine($"Your Result: {num1} + {num2} = " + (num1+num2));
                     break;
                 case "s":
                     Console.WriteLine($"Your Result: {num1} - {num2} = " + (num1 - num2));
                     break;
                 case "m":
                     Console.WriteLine($"Your Result: {num1} * {num2} = " + (num1 * num2));
                     break;
                 case "d":
                     //ok this is accounting for divide by Zero! LEARNIN' WOOT!
                     while (num2 == 0)
                     {
                         Console.WriteLine("Enter a non-zero divisor:");
                         num2 = Convert.ToInt32(Console.ReadLine());
                     }
                     Console.WriteLine($"Your Result: {num1} / {num2} = " + (num1 / num2));
                     break;

             }
             // Wait for the user to respond before closing.
             Console.WriteLine("Press any Key to close the Calculator! YEW LEEEARNIN'!!");
             Console.ReadKey();

        */
        #endregion
    }

