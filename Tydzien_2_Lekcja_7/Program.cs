using System;

namespace Tydzien_2_Lekcja_7
    // szkoła dotneta, ćwiczenia tydzień 2, lekcja 7 
{
    class Program
    {
        static void Main(string[] args)
        {
            Outputs.ShowAnswer($"Wybierz odpowiednią opcję.\r\nSprawdź:\r\n");

            string Menu, Answer = "";
            byte Option;
            bool MenuOK;
            int Number;

            Menu = $"1 - Czy liczby są równe\r\n";
            Menu += $"2 - Czy liczby parzyste\r\n";
            Menu += $"3 - Lcziba dodatnia, czy ujemna\r\n";
            Menu += $"4 - Czy rok przestępny\r\n";
            Menu += $"5 - Kim możesz zostać\r\n";
            Menu += $"6 - Kategorie wzrostu\r\n";
            Menu += $"7 - Która z liczb jest największa\r\n";
            Menu += $"8 - Czy zostaniesz dopuszczony do matury\r\n";
            Menu += $"9 - Kategorie temperatury\r\n";
            Menu += $"10 - Czy mozna zbudwoać trójkąt\r\n";
            Menu += $"11 - Oceny słownie\r\n";
            Menu += $"12 - Dni tygodnia słownie\r\n";
            Menu += $"13 - Kalkulator\r\n";

            Outputs.ShowAnswer(Menu);
            MenuOK = byte.TryParse(Console.ReadLine(), out Option);
            if (!MenuOK)
            { Answer = "Nie wybrano żadnej poprawnej opcji"; }
            else
            {
                switch (Option)
                {
                    case 1:
                        //--- 1 Liczby równe
                        Outputs.ShowAnswer("Wprowadź liczbę a:");
                        int Number1 = Int32.Parse(Console.ReadLine());
                        Outputs.ShowAnswer("Wprowadź liczbę b:");
                        int Number2 = Int32.Parse(Console.ReadLine());
                        if (Number1 == Number2)
                        {
                            Answer = $"{Number1} i {Number2} są równe";
                        }
                        else
                        {
                            Answer = $"{Number1} i {Number2} nie są równe";
                        }
                        break;
                    //---2  Liczby parzyste
                    case 2:
                        Outputs.ShowAnswer("Wprowadź liczbę:");
                        Number = Int32.Parse(Console.ReadLine());

                        if (Number % 2 == 0)
                        {
                            Answer = $"{Number} jest liczbą parzystą.";
                        }
                        else
                        {
                            Answer = $"{Number} jest liczbą nieparzystą.";
                        }
                        break;
                    // --- 3 dodatnia czy ujemna
                    case 3:
                        Outputs.ShowAnswer("Wprowadź liczbę:");
                        Number = Int32.Parse(Console.ReadLine());
                        if (Number > 0)
                        {
                            Answer = $"{Number} jest liczbą dodanią.";
                        }
                        else if (Number < 0)
                        {
                            Answer = $"{Number} jest liczbą ujemną.";
                        }
                        else
                        {
                            Answer = $"{Number} Nie jest ani liczbą dodatnią, ani ujemną!.";
                        }
                        break;
                    // --- 4 rok przestępny
                    // --- czyli jest podzielny przez 4 i nie jest podzielny przez 100 lub jest podzielny przez 400
                    case 4:
                        Outputs.ShowAnswer("Podaj rok:");
                        Number = Int32.Parse(Console.ReadLine());
                        if ((Number % 4 == 0 && Number % 100 != 0) || Number % 400 == 0)
                        {
                            Answer = $"{Number} jest rokiem przestępnym.";
                        }
                        else
                        {
                            Answer = $"{Number} Nie jest jest rokiem przestępnym.";
                        }
                        break;
                    // --- 5 kim możesz zostać
                    // ---- 21 - poseł, premier, 30 - senator, 35 - prezydent
                    case 5:

                        Outputs.ShowAnswer("Podaj wiek:");
                        Number = Int32.Parse(Console.ReadLine());
                        if (Number >= 21)
                        {
                            Answer = "Możesz zostać posłem, premierem";
                        }
                        else
                        {
                            Answer = "Nie możesz pisatować żadnej funkcji";
                        }
                        if (Number >= 30)
                        {
                            Answer += ", senatorem";
                        }
                        if (Number >= 35)
                        {
                            Answer += ", prezydentem RP";
                        }
                        Answer += ".";
                        break;
                    // ---- 6 -kategoria wzrostu
                    case 6:

                        Outputs.ShowAnswer("Podaj wzrost:");
                        Number = Int32.Parse(Console.ReadLine());
                        if (Number < 30 || Number > 250)
                        {
                            Answer = "Podaj prawidłową wartość.";
                        }
                        else
                        {
                            if (Number <= 140)
                            {
                                Answer = "Kurdupel.";
                            }
                            else if (Number <= 160)
                            {
                                Answer = "Bez szału.";
                            }
                            else if (Number <= 180)
                            {
                                Answer = "Przeciętniak.";
                            }
                            else
                            {
                                Answer = "Wielkolud";
                            }
                        }
                        break;
                    /// ---- która największa
                    case 7:
                        int[] Numbers = new int[3];
                        int MaxValue = 0;
                        for (int i = 0; i < Numbers.Length; i++)
                        {
                            Console.WriteLine("Podaj liczbę " + (i + 1));
                            Numbers[i] = Int32.Parse(Console.ReadLine());
                            if (i == 0)
                            {
                                MaxValue = Numbers[i];
                            }
                            else
                            {
                                if (Numbers[i] > MaxValue)
                                {
                                    MaxValue = Numbers[i];
                                }
                            }
                        }
                        Answer = $"{MaxValue} jest największa z podanych";
                        break;
                    
                        // ----- rekrutacja maturalana
                    case 8:
                        Console.WriteLine("Podaj wynik z matematyki:");
                        int Mat = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj wynik z fizyki:");
                        int Fiz = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj wynik z chemii:");
                        int Chem = Int32.Parse(Console.ReadLine());

                        if ((Mat > 70 && Fiz > 55 && Chem > 45 && Mat + Fiz + Chem > 180) || (Mat + Fiz > 150 || Mat + Chem > 150))
                        {
                            Answer = "Kandydat dopuszczony do rekrutacji.";
                        }
                        else
                        {
                            Answer = "Kandydat niedopuszczony do rekrutacji.";
                        }
                        break;
                    //-------- Kategoria temperaturowa
                    case 9:
                        //---------- nie dziala mi switch z operatorami<> :(pisze, że wymagana wersja C# 9.0 lub wyższa
                        //Temp < 0 – cholernie piździ
                        //Temp 0 – 10 – zimno
                        //Temp 10 – 20 – chłodno
                        //Temp 20 – 30 – w sam raz
                        //Temp 30 – 40 – zaczyna być słabo, bo gorąco
                        //Temp >= 40 – a weź wyprowadzam się na Alaskę.
                        Console.WriteLine("Podaj temperaturę:");
                        Number = Int32.Parse(Console.ReadLine());
                        if (Number < 0)
                        {
                            Answer = "Cholernie piździ.";
                        }
                        else if (Number <= 10)
                        {
                            Answer = "Zimno.";
                        }
                        else if (Number <= 20)
                        {
                            Answer = "Chłodno.";
                        }
                        else if (Number <= 30)
                        {
                            Answer = "W sam raz.";
                        }
                        else if (Number <= 40)
                        {
                            Answer = "Zaczyna być słabo, bo gorąco.";
                        }
                        else
                        {
                            Answer = "A weź wyprowadzam się na Alaskę.";
                        }
                        break;

                    // ---- czy mozna zbudowac trójkąt 
                    case 10:
                        Console.WriteLine("Podaj długość boku a:");
                        int a = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj długość boku b:");
                        int b = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj długość boku c:");
                        int c = Int32.Parse(Console.ReadLine());
                        bool OK = (a > 0 && b > 0 && c > 0) ? true : false;
                        OK =  (OK && a < b + c && b < a + c && c < a + b) ? true : false;

                        Answer = (OK) ? "Można zbudować trojkąt" : "Niestety, nie można zbudować trójkąta";
                        break;
                    // ---- oceny słownie
                    case 11:
                        string Info = "Podaj ocenę w skali 1 - 6:";
                        do
                        {
                            Console.WriteLine(Info);
                            Number = Int32.Parse(Console.ReadLine());
                            Info = "Podano niepoprawną wartość. Podaj ponownie ocenę w skali 1 - 6:";
                        }
                        while (Number < 1 || Number > 6);
                        
                        string[] Oceny = new string[6] {"Niedostateczny", "Dopuszczający", "Dostateczny",
                            "Dobry", "Bardzo dobry", "Celujący" };
                        Answer = Oceny[Number - 1];
                        break;
                    case 12:
                        Info = "Podaj dzień tygodnia (1-7):";
                        bool Verif;
                        do
                        {
                            Console.WriteLine(Info);
                            string TypedText = Console.ReadLine();
                            Verif =  Int32.TryParse(TypedText,out Number);
                            if (!Verif || Number < 1 || Number > 7)
                            {
                                Verif = false;
                                Info = $"Wprowadzono nieprawidłowe dane.\r\nSpróbuj ponownie lub naśnij klawisz 'K', aby zakończyć program.";
                            }
                            if (TypedText.ToLower() == "k")
                            {
                                System.Environment.Exit(0);
                            }
                        }
                        while(Verif == false);

                        int [] WeekDays = new int [7];
                        Answer = "Podano prawidłową liczbę.";

                        break;
                    // ----- kalkulator
                    case 13:
                        Console.WriteLine("Podaj pierwszą liczbę (a):");
                        double x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę (b):");
                        double y = double.Parse(Console.ReadLine());
                        Menu = "Wybierz działanie:\r\n\r\n";
                        Menu += $"1 - Dodawanie (a+b)\r\n";
                        Menu += $"2 - Odejmowanie (a-b)\r\n";
                        Menu += $"3 - Mnożenie (a*b)\r\n";
                        Menu += $"4 - Dzielenie (a/b)\r\n";
                        
                        Console.WriteLine(Menu);

                                                int Operation = Int32.Parse(Console.ReadLine());
                        double Result = 0;
                        switch (Operation)
                        {
                            case 1:
                                Result = x + y;
                                break;
                            
                            case 2:
                                Result = x - y;
                                break;
                            
                            case 3:
                                Result = x * y;
                                break;

                            case 4:
                                Result = x / y;
                                break;
                        }

                        Answer = $"Twój wynik to: {Result}";
                        break;

                    ////////////////////////////
                    default:
                    Answer = "Nie wybrano żadnej poprawnej opcji";
                    break;
                }
            }
            Answer = $"\r\n{Answer}";
            Outputs.ShowAnswer(Answer);
        }
    }
}
