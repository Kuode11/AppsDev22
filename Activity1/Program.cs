using Arithmetic;
using System.Security.Cryptography.X509Certificates;

namespace Arithmetic
{

    public class MathOperations
    {
        
            public void Add(int num1, int num2)
            {
             Console.WriteLine("Äddition: " + (num1 + num2));
            }

            public void Subtract(int num1, int num2)
            {
             Console.WriteLine("Subtraction: " + (num1 - num2));
        }

             public void Multiply(int num1, int num2)
            {
             Console.WriteLine("Multiplication: " + (num1 * num2));
        }

            public void Divide(int num1, int num2)
            {
             Console.WriteLine("Division: " + (num1 / num2)); ;
            }
        }
    }

class Program
{ 
static void Main(String[] args) 
{
        MathOperations mo = new MathOperations();
    int num1, num2;

        Console.WriteLine("Enter Num1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Num2: ");
        num2 = int.Parse(Console.ReadLine());

        mo.Add(num1, num2);
        mo.Subtract(num1, num2);
        mo.Multiply(num1, num2);
        mo.Divide(num1, num2);
    }
}