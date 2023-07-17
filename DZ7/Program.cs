using System.Diagnostics;

namespace DZ7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toDo = 5;
            bool closeWhile = false;

            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (closeWhile == false)
            {
                int znachenie = 0;

                Console.WriteLine("для значения " + a);
                Console.ForegroundColor = ConsoleColor.Red;
                var sw = Stopwatch.StartNew();
                Fibanachi(a);
                sw.Stop();
                Console.WriteLine("время = " + sw.ElapsedMilliseconds + " тики = " + sw.ElapsedTicks);

                Console.ForegroundColor = ConsoleColor.Green;
                sw.Restart();
                var v = FibonachiRecurs(a);
                sw.Stop();
                Console.WriteLine("Рекурсия Фибоначчи = " + v);
                Console.WriteLine("время = " + sw.ElapsedMilliseconds + " тики = " + sw.ElapsedTicks);
                Console.ResetColor();
                Console.WriteLine();

                switch (toDo) 
                { 
                    case 5:
                        a = toDo;
                        toDo = toDo * 2;
                        break;
                    case 10:
                        a = toDo;
                        toDo = toDo * 2;
                        break;
                    case 20:
                        a = toDo;
                        toDo = toDo * 2;
                        break;
                    default: 
                        closeWhile = true; 
                        break;
                }
            }
        }

        public static void Fibanachi(int a)
        {
            int znachenie1 = 0, znachenie2 = 1, znachenie = 0;

            for (int i = 1; i < a; i++)
            {
                znachenie = znachenie1 + znachenie2;
                znachenie1 = znachenie2;
                znachenie2 = znachenie;
            }
            Console.WriteLine("Цикл Фибоначчи = " + znachenie);
        }

        static int FibonachiRecurs(int a)
        {
            if (a == 0) return 0;
            if (a == 1 || a == 2) return 1;
            return FibonachiRecurs(a - 1) + FibonachiRecurs(a - 2);
        }
    }
}