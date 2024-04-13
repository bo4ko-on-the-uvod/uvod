using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boris_8g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задача 3-та
            Console.Write("Input hours: "); // Подканва потребителят да въведе час
            int h = Convert.ToInt32(Console.ReadLine()); // Дава поле за въвеждане на потребителя
            Console.Write("Input minutes: ");// Подканва потребителят да въведе минута
            int m = Convert.ToInt32(Console.ReadLine());// Дава поле за въвеждане на потребителя
            m = m + 15; // Добавя 15 единици към минутите
            if (m >= 59) // Прави проверка дали променливата е по голяма или равна на 59
            {
                m = m - 60; // Премахва от променливата 60
                h = h + 1; // Добавя към променливата 1
            }
            if (h == 24) // Проверява дали h е равно на 24
            {
                h = 0; // Прави стойноста на променливата на 0
            }
            if (h < 9) // Проверява дали променливата е по-малка от 9
            {
                Console.WriteLine("Часът след 15 мин ще бъде 0" + h + ":" + m); // Извежда часа с 0 от пред
            }
            else
            {
                Console.WriteLine("Часът след 15мин ще бъде " + h + ":" + m); // Извежда часа
            }
            Console.ReadLine(); // Чака да се натисне enter за да се пробължи на пред
            //задача 2-ра
            Console.Write("Input first word: "); // Подканва потребителят да въведе дума
            string word1 = Console.ReadLine(); // Дава възможност на потребителят да въведе дума
            Console.Write("Input second word: "); // Подканва потребителят да въведе дума
            string word2 = Console.ReadLine(); // Дава възможност на потребителят да въведе дума
            string w1 = word1.ToLower(); // Предава стойноста на друга променлвиа като прави всички букви малки
            string w2 = word2.ToLower(); // Предава стойноста на друга променлвиа като прави всички букви малки
            if (w1 == w2) // Проверява за съвместимост между двете променливи
            {
                Console.WriteLine("Yes"); // Отпечатва "Yes"
            }
            else // Ако горното условие не е изпълнено
            {
                Console.WriteLine("No"); // Отпечатва "No"
            }
            Console.ReadLine();// Чака да се натисне enter за да се пробължи на пред
            //задача 4-та
            Console.Write("Input number one: "); // Подканва потребителят да въведе цифра
            string number_one = Console.ReadLine(); // Дава възможност на потребителят да въведе цифра
            Console.Write("Input number two: "); // Подканва потребителят да въведе цифра
            string number_two = Console.ReadLine(); // Дава възможност на потребителят да въведе цифра
            Console.Write("Input number three: "); // Подканва потребителят да въведе цифра
            string number_three = Console.ReadLine(); // Дава възможност на потребителят да въведе цифра
            if (number_one == number_two) // Проверява дали променливите са еднакви
            {
                if (number_two == number_three) // Проверява дали променливитре са еднакви
                {
                    Console.WriteLine("Same :)"); // Отпечатва в конзолата
                }
                else
                {
                    Console.WriteLine("Not same ;("); // Отпечатва в конзолата
                }
            }
            else
            {
                Console.WriteLine("Not same ;("); //Отпечатва в конзолата
            }
            //задача 1-ва
            Console.ReadLine(); // Изчква потребителят да натисне enter за да продължи
            string password = "12345"; // Задава стойност на променливата
            Console.Write("Input password: "); // Приканва потребителят да въведе парола
            string p = Console.ReadLine(); // Дава възможност на потребителят да въведе парола
            if (p == password) // Проверява дали променливите имат еднакви стойсноти
            {
                Console.WriteLine("Welcome!"); // Отпечатва "Welcome"
            }
            else
            {
                Console.WriteLine("Bye"); // Отпечатва "Bye"
            }
            Console.ReadLine(); // Остава конзолата отворена
        }
    }
}
