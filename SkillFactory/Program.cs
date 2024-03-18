using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterUser();
            ShowData();
        }
        static (string Name, string LastName, int Age, int NumPet, int NumFavColor,bool HavePet, string[] PetName, string[] favColor) User;

        static (string Name, string LastName, int Age, int NumPet, int NumFavColor, bool HavePet, string[] PetName, string[] favColor) EnterUser()
        {
            Console.WriteLine("Введите Имя ");

            User.Name = Console.ReadLine();

            Console.WriteLine("Введите Фамилию ");

            User.LastName = Console.ReadLine();

            string Age; 
            int intage;

            do
            {
                Console.WriteLine("Введите возраст цифрами");
                Age = Console.ReadLine();

            } while (CheckNum(Age, out intage));

            User.Age = intage;

            Console.Write("У вас есть домашний питомец?(Да/Нет): ");
            var PetResult = Console.ReadLine();

            while (PetResult != "Да" && PetResult != "Нет")

            {
                Console.WriteLine("Неправильно, введите Да или Нет");
                PetResult = Console.ReadLine();
            }
            if (PetResult == "Да")
            {
                User.HavePet = true;
                string pet;
                int intpet;
                do
                {
                    Console.WriteLine("Введите количество питомцев: ");
                    pet = Console.ReadLine();
                } while (CheckNum(pet, out intpet));

                User.NumPet = intpet;
                string[] PetName = new string[intpet];


                Console.WriteLine($"Введите имя питомца: ");
                for (int i = 0; i < intpet; i++)
                {

                    PetName[i] = Console.ReadLine();

                }
                User.PetName = PetName;
            }
            else
            {
                User.NumPet = 0;
            }
           
            string colors;
            int intcolors;
            do
            {
                Console.WriteLine("Напишите количество любимых цветов цифрами");
                colors = Console.ReadLine();
            } 
            while (CheckNum(colors, out intcolors));
            User.NumFavColor = intcolors;
            User.favColor = new string[User.NumFavColor];

            for (int i = 0; i < User.NumFavColor; i++)
            {
                Console.WriteLine($"Введите любимый цвет {i + 1}: ");
                User.favColor[i] = Console.ReadLine();
            }
            return User;
        }


        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            }
        }
        static (string Name, string LastName, int Age, int NumPet, int NumFavColor, bool HavePet, string[] PetName, string[] favColor) ShowData()
        {
            Console.WriteLine($"Имя: {User.Name}");
            Console.WriteLine($"Фамилия: {User.LastName}");
            Console.WriteLine($"Возраст: {User.Age}"); 
            if (User.HavePet)
            {
                Console.WriteLine($"Количество питомцев: {User.NumPet}");
                Console.WriteLine("Клички питомцев:");
                foreach (string pet in User.PetName)
                {
                    Console.WriteLine(pet);
                }
            }
            else
            {
                Console.WriteLine("У пользователя нет питомцев");
            }
            Console.WriteLine($"Количество любимых цветов: {User.NumFavColor}");
            Console.WriteLine("Любимые цвета:");
            foreach (string col in User.favColor)
            {
                Console.WriteLine(col);
            }
            return User;
        }


    }
}
    


