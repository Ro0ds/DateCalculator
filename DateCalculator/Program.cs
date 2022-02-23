using System;
using System.Windows.Forms;
using DateCalculator.Entities;

namespace DateCalculator {
    class Program {
        static void Main(string[] args) {
            char ch;
            double value;

            Calculate calculate = new Calculate();

            start:
            Console.Clear();
            Console.WriteLine("||------------||");
            Console.WriteLine("|| 1 - Years  ||");
            Console.WriteLine("|| 2 - Months ||");
            Console.WriteLine("|| 3 - Weeks  ||");
            Console.WriteLine("|| 4 - Days   ||");
            Console.WriteLine("||------------||");

            Console.WriteLine();
            Console.Write("Choice: ");
            ch = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (ch == '1') {
                Console.Write("Years: ");
                value = double.Parse(Console.ReadLine());
                calculate.Calc(value, ch);
            }
            else if (ch == '2') {
                Console.Write("Months: ");
                value = double.Parse(Console.ReadLine());
                calculate.Calc(value, ch);
            }
            else if (ch == '3') {
                Console.Write("Weeks: ");
                value = double.Parse(Console.ReadLine());
                calculate.Calc(value, ch);
            }
            else if (ch == '4') {
                Console.Write("Days: ");
                value = double.Parse(Console.ReadLine());
                calculate.Calc(value, ch);
            }
            else {
                MessageBox.Show("Wrong number, try again");
            }

            Console.WriteLine(calculate);

            Console.WriteLine();
            Console.Write("Again? (y/n): ");
            char ch1 = char.Parse(Console.ReadLine());

            if (ch1 == 'y') {
                goto start;
            }
        }
    }
}
