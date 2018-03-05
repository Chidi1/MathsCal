using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsCal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...just try it out");
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi {0}, How are you doing", name);
            
            while (true)
            {
                Console.WriteLine("Please enter one of the following operations '+', '-', 'x', '/'");
                string operand = Console.ReadLine();
                
                if (operand == "+" || operand == "-" || operand == "x" || operand == "/")
                {
                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                    while (true)
                    {
                        try
                        {
                            int diff = Convert.ToInt32(Console.ReadLine());
                            switch (diff)
                            {
                                case 1:
                                    Program.difficulty1(operand);
                                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                                    break;
                                case 2:
                                    Program.difficulty2(operand);
                                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                                    break;
                                case 3:
                                    Program.difficulty3(operand);
                                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                                    break;
                                default:
                                    Console.WriteLine("Please select diffulty level of 1, 2 or 3");
                                    break;
                            }
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                              Console.ReadLine().GetType().Name, Console.ReadLine());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter a valid operand.");                  
                }
                
            }            
        }
        public static void difficulty1(string op)
        {
            Console.WriteLine("You chose diffculty level 1");
            Console.WriteLine("How many questions would you want to answer?");
            string input = Console.ReadLine();
            int qNo = 0;
            int userAnswer = 0;
            int correctCount = 0;

            try
            {
                qNo = Convert.ToInt32(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                  Console.ReadLine().GetType().Name, Console.ReadLine());
            }
            int x = 0;
            while (x < qNo)
            {
                x++;
                int answer = 0;
                Random rdm = new Random();
                int rdmInt1 = rdm.Next(1, 10);
                int rdmInt2 = rdm.Next(1, 10);
                if (op == "/")
                {
                    double higherNumber = Convert.ToDouble( Math.Max(rdmInt1, rdmInt2));
                    double lowerNumber = Convert.ToDouble(Math.Min(rdmInt1, rdmInt2));
                    Console.WriteLine("What is {0} {1} {2} ?", higherNumber, op, lowerNumber);
                    double divAnswer = higherNumber / lowerNumber;

                    double divUserAnswer = Convert.ToDouble(Console.ReadLine());

                    if (divUserAnswer == divAnswer)
                    {
                        Console.WriteLine("Congrats! You got the answer");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine("Faild! The correct answer is {0}", divAnswer);
                    }
                }
                else
                {
                    Console.WriteLine("What is {0} {1} {2} ?", rdmInt1, op, rdmInt2);
                    if (op == "+")
                    {
                        answer = rdmInt1 + rdmInt2;
                    }
                    else if (op == "-")
                    {
                        answer = rdmInt1 - rdmInt2;
                    }
                    else
                    {
                        answer = rdmInt1 * rdmInt2;
                    }

                    userAnswer = Convert.ToInt32(Console.ReadLine());

                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Congrats! You got the answer");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine("Faild! The correct answer is {0}", answer);
                    }
                }
            }
            double passRate = Convert.ToDouble(correctCount) / Convert.ToDouble(qNo);
            double passPercentage = passRate * 100.0;
            if (passPercentage > 50)
            {
                Console.WriteLine("You did alright, your total score is {0}/{1}", correctCount, qNo);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }
            else
            {
                Console.WriteLine("Your total score is {0}/{1}", correctCount, qNo);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }
        }
        public static void difficulty2(string op)
        {
            Console.WriteLine("You chose diffculty level 2");
            Console.WriteLine("How many questions would you want to answer?");
            string input = Console.ReadLine();
            int qNo = 0;
            int userAnswer = 0;
            int correctCount = 0;

            try
            {
                qNo = Convert.ToInt32(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                  Console.ReadLine().GetType().Name, Console.ReadLine());
            }
            int x = 0;
            while (x < qNo)
            {
                x++;
                int answer = 0;
                Random rdm = new Random();
                int rdmInt1 = rdm.Next(10, 100);
                int rdmInt2 = rdm.Next(10, 100);
                if (op == "/")
                {
                    double higherNumber = Convert.ToDouble(Math.Max(rdmInt1, rdmInt2));
                    double lowerNumber = Convert.ToDouble(Math.Min(rdmInt1, rdmInt2));
                    Console.WriteLine("What is {0} {1} {2} ?", higherNumber, op, lowerNumber);
                    double divAnswer = higherNumber / lowerNumber;

                    double divUserAnswer = Convert.ToDouble(Console.ReadLine());

                    if (divUserAnswer == divAnswer)
                    {
                        Console.WriteLine("Congrats! You got the answer");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine("Faild! The correct answer is {0}", divAnswer);
                    }
                }
                else
                {
                    Console.WriteLine("What is {0} {1} {2} ?", rdmInt1, op, rdmInt2);
                    if (op == "+")
                    {
                        answer = rdmInt1 + rdmInt2;
                    }
                    else if (op == "-")
                    {
                        answer = rdmInt1 - rdmInt2;
                    }
                    else
                    {
                        answer = rdmInt1 * rdmInt2;
                    }

                    userAnswer = Convert.ToInt32(Console.ReadLine());

                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Congrats! You got the answer");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine("Failed! The correct answer is {0}", answer);
                    }
                }
            }
            double passRate = Convert.ToDouble(correctCount) / Convert.ToDouble(qNo);
            double passPercentage = passRate * 100.0;
            if (passPercentage > 50)
            {
                Console.WriteLine("You did alright, your total score is {0}/{1}", correctCount, qNo);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }
            else
            {
                Console.WriteLine("Your total score is {0}/{1}", correctCount, qNo);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }
        }
        public static void difficulty3(string op)
        {
            Console.WriteLine("You chose diffculty level 3");
            Console.WriteLine("How many questions would you want to answer?");
            string input = Console.ReadLine();
            int qNo = 0;
            int userAnswer = 0;
            int correctCount = 0;

            try
            {
                qNo = Convert.ToInt32(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                  Console.ReadLine().GetType().Name, Console.ReadLine());
            }
            int x = 0;
            while (x < qNo)
            {
                x++;
                int answer = 0;
                Random rdm = new Random();
                int rdmInt1 = rdm.Next(100, 10000);
                int rdmInt2 = rdm.Next(100, 10000);
                if (op == "/")
                {
                    double higherNumber = Convert.ToDouble(Math.Max(rdmInt1, rdmInt2));
                    double lowerNumber = Convert.ToDouble(Math.Min(rdmInt1, rdmInt2));
                    Console.WriteLine("What is {0} {1} {2} ?", higherNumber, op, lowerNumber);
                    double divAnswer = higherNumber / lowerNumber;

                    double divUserAnswer = Convert.ToDouble(Console.ReadLine());

                    if (divUserAnswer == divAnswer)
                    {
                        Console.WriteLine("Congrats! You got the answer");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine("Faild! The correct answer is {0}", divAnswer);
                    }
                }
                else
                {
                    Console.WriteLine("What is {0} {1} {2} ?", rdmInt1, op, rdmInt2);
                    if (op == "+")
                    {
                        answer = rdmInt1 + rdmInt2;
                    }
                    else if (op == "-")
                    {
                        answer = rdmInt1 - rdmInt2;
                    }
                    else
                    {
                        answer = rdmInt1 * rdmInt2;
                    }

                    userAnswer = Convert.ToInt32(Console.ReadLine());

                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Congrats! You got the answer");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine("Failed! The correct answer is {0}", answer);
                    }
                }
            }
            double passRate = Convert.ToDouble(correctCount) / Convert.ToDouble(qNo);
            double passPercentage = passRate * 100.0;
            if (passPercentage > 50)
            {
                Console.WriteLine("You did alright, your total score is {0}/{1}", correctCount, qNo);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }
            else
            {
                Console.WriteLine("Your total score is {0}/{1}", correctCount, qNo);
                Console.WriteLine("You have a pass rate of {0}%", passPercentage);
            }
        }
    }
}
