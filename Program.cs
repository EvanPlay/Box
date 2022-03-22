using System;
namespace Box
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Я - Руслан. Программа для вывода квадратов из нулей и единиц, где единицы есть диагонали квадрата.");
            Console.WriteLine("Пожалуйста, введите число - стороны квадрата.");
            string chislo = Console.ReadLine();
            int x;//программа принимает введённое пользователем число
            x = Convert.ToInt32(Console.ReadLine());
            try
            {
                createBox createBox = new createBox();//через класс оно просчитывет его и выводит
                while (true)
                {
                    createBox.Square(x);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}


    //{
    //    static string Yes = "Да";
    //    static string No = "Нет";
    //    static string Exit = "Выйти";
    //    static void Main(string[] args)
    //    {
    //        while (true)
    //        {
    //            Console.WriteLine("Я - Руслан. Программа для вывода квадратов из нулей и единиц, где единицы есть диагонали квадрата.");
    //            string chislo = Console.ReadLine();
    //            Console.WriteLine("Пожалуйста, введите число - стороны квадрата.");

    //            int x;
    //            x = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine($"Вы уверены, что хотите получить квадрат со сторонами {x}? Если вы уверены, то введите \"{Yes}\". Если вы не уверены, то напишите \"{No}\"");
    //            switch (Console.ReadLine().ToLower().TrimStart().TrimEnd())
    //            {
    //                case "Да": Yes(); break;
    //                case "Нет": No(); break;
    //                case "Выйти":; return();
    //                default; Console.WriteLine($"Извените, но я могу принимать только команды \"{Yes}\",\"{No}\" или \"{Exit}\", а так же то число, каким вы обозначаете размер стороны квадрата");
    //                    break;
    //            }
    //            Console.WriteLine();
    //        }
    //        static void Yes()
    //        {
    //            Console.WriteLine("Ваш квадрат: ");
    //            CreateBox.Square(x);
    //        }
    //    }
//    }
//}
