using System;
using System.Globalization;

namespace ParametryTrojkata
{
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Console.WriteLine("Podaj długości trzy długości boków po przecinku.");

            string input = Console.ReadLine();
            string[] elements = input.Split(',');
            if (elements.Length == 3)
            {
                float A = float.Parse(elements[0]);
                float B = float.Parse(elements[1]);
                float C = float.Parse(elements[2]);

                float sumaABC = A + B + C;

                bool ostrokatny = (A * A + B * B > C * C) && (A * A + C * C > B * B) && (B * B + C * C > A * A);
                bool rozwartokatny = (A * A + B * B < C * C) || (A * A + C * C < B * B) || (B * B + C * C < A * A);

                if (sumaABC <= 0)
                {
                    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                    return;
                }
                if (A <= 0)
                {
                    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                    return;
                }
                if (B <= 0)
                {
                    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                    return;
                }
                if (C <= 0)
                {
                    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                    return;
                }
                else if (A + B < C || A + C < B || B + C < A)
                {
                    Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
                    return;
                }
                else
                {
                    float obwod = A + B + C;
                    Console.WriteLine($"obwód = {obwod:F2}");

                    float s = obwod / 2;
                    float pole = (float)Math.Sqrt(s * (s - A) * (s - B) * (s - C));
                    Console.WriteLine($"pole = {pole:F2}");

                }
                if (C * C == A * A + B * B)
                {
                    Console.WriteLine("trójkąt jest prostokątny");
                }
                if (ostrokatny)
                {
                    Console.WriteLine("trójkąt jest ostrokątny");
                }
                if (rozwartokatny)
                {
                    Console.WriteLine("trójkąt jest rozwartokątny");
                }
                if (A == B && B == C)
                {
                    Console.WriteLine("trójkąt równoboczny");
                }
                else if (A == B || B == C || C == A)
                {
                    Console.WriteLine("trójkąt równoramienny");
                }
            }
        }
    }
}