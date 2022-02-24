using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8.NetFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Greeting);

            if (string.IsNullOrEmpty(Properties.Settings.Default.Name) || string.IsNullOrEmpty(Properties.Settings.Default.Age) || string.IsNullOrEmpty(Properties.Settings.Default.KindOfActivity))
            {
                Console.WriteLine("Введите имя пользователя: ");

                Properties.Settings.Default.Name = Console.ReadLine();

                Console.WriteLine("Введите возраст пользователя: ");

                Properties.Settings.Default.Age = Console.ReadLine();

                Console.WriteLine("Введите вид деятельности");

                Properties.Settings.Default.KindOfActivity = Console.ReadLine();

                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"Пользователь: {Properties.Settings.Default.Name}. Возраст пользователя: {Properties.Settings.Default.Age}. Вид деятельности: {Properties.Settings.Default.KindOfActivity}");

            }


        }
    }
}
