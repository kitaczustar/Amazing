using System;

namespace Amazing.Cmd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Witaj w świecie gry Amazing!");
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Jaką płeć ma twoja postać? (boy/girl):");
            var płeć = Console.ReadLine();

            // znak '||' znaczy 'lub'
            // znak '&&' znaczy 'i'
            if (płeć != "girl" && płeć != "boy")
            {
                Console.WriteLine("Niepoprawna podana płeć");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Jakiej chcesz być rasy? (cat/ghost/wolf/human)");
            var rasa = Console.ReadLine();

            if (rasa != "cat" && rasa != "ghost" && rasa != "wolf" && rasa != "human")
            {
                Console.WriteLine("Niepoprawna podana rasa");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Podaj swój wiek:");
            var wiek = Console.ReadLine();


            Console.WriteLine("Twoja postać to:");
            Console.WriteLine($"płeć: {płeć}");
            Console.WriteLine($"rasa: {rasa}");
            Console.WriteLine($"wiek: {wiek}");

            Console.WriteLine();

            Console.WriteLine("Gdzie zaczynasz swoją przygodę?");
            Console.WriteLine("1-PorannaWioska");
            Console.WriteLine("2-JezioroWspomnień");
            Console.WriteLine("3-LiściasteWzgórze");
            Console.WriteLine("4-SnowCity)");
            
            var lokalizacja = Console.ReadLine();

            if (lokalizacja == "4")
            {
                Console.WriteLine("Śnieżne miasto, zima tutaj doskwiera przez cały rok.");
                Console.WriteLine("Nie znajdziesz osoby o złej duszy, każdy jest sobie życzliwy.");
            }

            if (lokalizacja == "1")
            {
                Console.WriteLine("Poranna Wioska cudownie to brzmi prawda? Tutaj wiosna nie ustepuje.");
                Console.WriteLine("Od rana wszyscy są czymś zajęci, nikt dla nikogo niema czasu.");
            }

            if (lokalizacja == "2")
            {
                Console.WriteLine("Jezioro Wspomnień pachnie wspomnieniami,lato tutaj nawet zatańczy walca...");
                Console.WriteLine("W tym terenie nie ma pośpiechu, wojownicy tylko zawsze się gdzieś śpieszą.");
            }

            if (lokalizacja == "3")
            {
                Console.WriteLine("Liściaste Wzgórze zakłopotanie to tutaj norma, jesień jest tutaj główą atrakcją.");
                Console.WriteLine("Jest tutaj zakłopotanie ponieważ do okoła trzeba wszystko ogarnąć, niestety jest tutaj najwięcej złodzieji a najmniej wojowników");
            }

            Console.WriteLine("W każdym regionie jest ukryta skrzynka z łupem. Zakopana przez dawnych wojowników, o dobrych duszach.");

            //End
            Console.ReadLine();
        }
    }
}
