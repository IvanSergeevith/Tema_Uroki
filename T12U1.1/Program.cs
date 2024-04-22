//Домашнее задание. Тема 12. Урок 1. Операторы
//ветвления Switch/ Case.

int count = 0;
do
{
    Console.WriteLine(
    "\n 1) (+)." +
    "\n 2) (-)." +
    "\n 3) (*)." +
    "\n 4) (/).");
    double choice = double.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:

            Console.Write(" Введите 1-е число:");
            double x = double.Parse(Console.ReadLine());
            Console.Write(" Введите 2-е число:");
            double y = double.Parse(Console.ReadLine());
            double z = x + y;
            Console.WriteLine($"{x}+{y}={z}");

            break;

        case 2:
            Console.Write(" Введите 1-е число:");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write(" Введите 2-е число:");
            double y1 = double.Parse(Console.ReadLine());
            double z1 = x1 - y1;
            Console.WriteLine($"{x1}-{y1}={z1}");
            break;


        case 3:
            Console.Write(" Введите 1-е число:");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write(" Введите 2-е число:");
            double y2 = double.Parse(Console.ReadLine());
            double z2 = x2 * y2;
            Console.WriteLine($"{x2}*{y2}={z2}");
            break;

        case 4:
            Console.Write(" Введите 1-е число:");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write(" Введите 2-е число:");
            double y3 = double.Parse(Console.ReadLine());
            double z3 = x3 / y3;
            Console.WriteLine($"{x3}/{y3}={z3}");
            break;
        default:
            Console.WriteLine("НЕТ ТАКОЙ ФУНКЦИИ"); break;


    }

    ++count;
}
while (count < 10);



