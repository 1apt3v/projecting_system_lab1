
using Tyuiu.IstominNM.Lab1.Review.V2.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Истомин Н. М. | НТм-23-1";
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт #1                                                                  *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                    *");
        Console.WriteLine("* Задание #7                                                                 *");
        Console.WriteLine("* Вариант #15                                                                *");
        Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТ6-24-1                           *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                   *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по          *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до      *");
        Console.WriteLine("* знаков после запятой.                                                      *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
        Console.WriteLine("******************************************************************************");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(ds.Calc(x, y));
        Console.ReadKey();
    }

}