using System;
namespace CalculatorCSharp {
    internal static class Program {
        private static void Main(string[] args) {  
            Console.WriteLine("Select operation.");  
            Console.WriteLine("1.Add");  
            Console.WriteLine("2.Subtract");  
            Console.WriteLine("3.Multiply");  
            Console.WriteLine("4.Divide\n");
            
            var choice = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter first number: ");  
            var numberOne = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter second number: ");  
            var numberTwo = Convert.ToInt32(Console.ReadLine());
            
            var result = 0;  
            switch (choice) {  
                case 1: {  
                    result = Addition(numberOne, numberTwo);  
                    break;  
                }  
                case 2: {  
                    result = Subtraction(numberOne, numberTwo);  
                    break;  
                }  
                case 3: {  
                    result = Multiplication(numberOne, numberTwo);  
                    break;  
                }  
                case 4: {  
                    result = Division(numberOne, numberTwo);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Wrong Input, please make sure you don't fat-finger the wrong key.");  
                    break;  
            }  
            Console.WriteLine("The result is: {0}", result);  
            Console.ReadKey();  
        }
        private static int Addition(int numberOne, int numberTwo) {  
            var result = numberOne + numberTwo;  
            return result;  
        }
        private static int Subtraction(int numberOne, int numberTwo) {  
            var result = numberOne + numberTwo;  
            return result;  
        }
        private static int Multiplication(int numberOne, int numberTwo) {  
            var result = numberOne + numberTwo;  
            return result;  
        }
        private static int Division(int numberOne, int numberTwo) {  
            var result = numberOne + numberTwo;  
            return result;  
        }  
    }  
}  