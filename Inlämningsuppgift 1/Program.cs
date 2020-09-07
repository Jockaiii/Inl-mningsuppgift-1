using System;

namespace Inlämningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarera variabler & annat för att avändaren ska kunna ange operatorer och värden
            decimal a, b, c, svar;
            string op1, op2;
            int i;

            // läs in vad användaren anger
            Console.WriteLine("Ange operatör nummer 1:");
            op1 = Console.ReadLine();
            Console.WriteLine("Ange operatör nummer 2:");
            op2 = Console.ReadLine();
            Console.WriteLine("Ange första term:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange andra term:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange tredje term:");
            c = Convert.ToInt32(Console.ReadLine());

            // beräkna & skriv ut resultat
            if (op1 == "+" & op2 == "+")
            {
                svar = a + b + c;
                Console.WriteLine(a + "+" + b + "+" +  c + "=" + svar);
            }

            else if (op1 == "+" & op2 == "-")
            {
                svar = a + b - c;
                Console.WriteLine(a + "+" + b + "-" + c + "=" + svar);
            }

            else if (op1 == "+" & op2 == "*")
            {
                svar = a + b * c;
                Console.WriteLine(a + "+" + b + "*" + c + "=" + svar);
            }

            else if (op1 == "+" & op2 == "/")
            {
                svar = a + b / c;
                Console.WriteLine(a + "+" + b + "/" + c + "=" + svar);
            }

            else if (op1 == "-" & op2 == "+")
            {
                svar = a - b + c;
                Console.WriteLine(a + "-" + b + "+" + c + "=" + svar);
            }

            else if (op1 == "-" & op2 == "-")
            {
                svar = a - b - c;
                Console.WriteLine(a + "-" + b + "-" + c + "=" + svar);
            }

            else if (op1 == "-" & op2 == "*")
            {
                svar = a - b * c;
                Console.WriteLine(a + "-" + b + "*" + c + "=" + svar);
            }

            else if (op1 == "-" & op2 == "/")
            {
                svar = a - b / c;
                Console.WriteLine(a + "-" + b + "/" + c + "=" + svar);
            }

            else if (op1 == "*" & op2 == "+")
            {
                svar = a * b + c;
                Console.WriteLine(a + "*" + b + "+" + c + "=" + svar);
            }

            else if (op1 == "*" & op2 == "-")
            {
                svar = a * b - c;
                Console.WriteLine(a + "*" + b + "-" + c + "=" + svar);
            }

            else if (op1 == "*" & op2 == "*")
            {
                svar = a * b * c;
                Console.WriteLine(a + "*" + b + "*" + c + "=" + svar);
            }

            else if (op1 == "*" & op2 == "/")
            {
                svar = a * b / c;
                Console.WriteLine(a + "*" + b + "/" + c + "=" + svar);
            }

            else if (op1 == "/" & op2 == "+")
            {
                svar = a / b + c;
                Console.WriteLine(a + "/" + b + "+" + c + "=" + svar);
            }

            else if (op1 == "/" & op2 == "-")
            {
                svar = a / b - c;
                Console.WriteLine(a + "/" + b + "-" + c + "=" + svar);
            }

            else if (op1 == "/" & op2 == "*")
            {
                svar = a / b * c;
                Console.WriteLine(a + "/" + b + "*" + c + "=" + svar);
            }

            else if (op1 == "/" & op2 == "/")
            {
                svar = a / b / c;
                Console.WriteLine(a + "/" + b + "/" + c + "=" + svar);
            }

            else
            {

            }

        }
    }
}
