using System;

namespace M2L4_Typy_danych
{

    class Program
    {

        static void Main(string[] args)
        {
            // 1. Zmienne dotyczące danych pracownika firmy

            string firstName;

            string lastName;

            int age;

            bool isMale;

            int PESEL;

            int emplNum;

            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Witamy w aplikacji osobowej!");
            Console.Write("Podaj imię nowego pracownika: ");
            firstName = Console.ReadLine();
            
            Console.Write("Podaj nazwisko nowego pracownika: ");
            lastName = Console.ReadLine();
            
            Console.Write("Podaj wiek nowego pracownika: ");
            age = Convert.ToInt32(Console.ReadLine());

            
            // 2. Stworz 3 zmienne z jedną literą, a następnie wypisz je w odwrotnej kolejności niż zostały zadeklarowane
            
            Console.WriteLine();
            Console.WriteLine("Zadanie 2");

            char a = 'a';
            char b = 'b';
            char c = 'c';

            Console.WriteLine($"{c}, {b}, {a}");


            // 3. Na podstawie podanej szerokości i długości prostokąta wylicz długość przekątnej.
            
            Console.WriteLine();
            Console.WriteLine("Zadanie 3");

            double szerokosc;
            double dlugosc;
            double przekatna;
            
            Console.WriteLine("Witamy w aplikacji \"Długość przekątnej\"!");
            Console.Write("Podaj szerokość prostokąta: ");
            szerokosc = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość prostokąta: ");
            dlugosc = Convert.ToDouble(Console.ReadLine());

            przekatna = Math.Sqrt(Math.Pow(szerokosc, 2) + Math.Pow(dlugosc, 2));
            Console.WriteLine($"Długość przekątnej prostoktna wynosi: {przekatna}");


            // 4. Stworz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypisz im następujące wartości: a) 10, b) Szkoła Dotneta, c) 12,5
            
            Console.WriteLine();
            Console.WriteLine("Zadanie 4");

            double liczba1;
            double liczba2;
            string text;

            liczba1 = 10;
            liczba2 = 12.5;
            text = "Szkoła Dotneta";

            Console.WriteLine($"liczba1 = {liczba1}, liczba2 = {liczba2}, text = {text}");


            /* 5. Popros uzytkownika o jego dane personalne tj. Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej).
            *  i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
            *  typDanych.Parse(odpowiedźOdUżytkownika)
            */

            Console.WriteLine();
            Console.WriteLine("Zadanie 5");

            string name;
            string surname;
            int emplAge;
            int telephone;
            string email;
            double height;
            double weight;
            int nrPesel;
            int nrEmployee;
            string sex;
            string civilStatus;


            Console.WriteLine("Witamy w aplikacji osobowej!");
            Console.Write("Podaj swoje imię: ");
            name = Console.ReadLine();

            Console.Write("Podaj swoje nazwisko: ");
            surname = Console.ReadLine();

            Console.Write("Podaj swoj wiek: ");
            emplAge = int.Parse(Console.ReadLine());

            Console.Write("Podaj swoj numer telefonu: ");
            telephone = int.Parse(Console.ReadLine());

            Console.Write("Podaj swoj adres email: ");
            email = Console.ReadLine();

            Console.Write("Podaj swoj wzrost: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj swoja wage: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj swoj numer PESEL: ");
            nrPesel = int.Parse(Console.ReadLine());

            Console.Write("Podaj swoj numer pracownika: ");
            nrEmployee = int.Parse(Console.ReadLine());

            Console.Write("Podaj swoja plec: ");
            sex = Console.ReadLine();

            Console.Write("Podaj swoj stan cywilny: ");
            civilStatus = Console.ReadLine();


            Console.ReadKey();

        }
    }
}