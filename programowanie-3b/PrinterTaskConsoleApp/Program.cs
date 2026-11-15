/*
Drukarka wybrana do wydruku

Napisz program obsługujący wydruk na wybranej drukarce.
- Utwórz klasę Printer z automatyczną właściwością Name oraz prywatnym polem przechowującym liczbę arkuszy. Udostępnij właściwość PaperCount z odczytem i zapisem. Próba ustawienia ujemnej liczby arkuszy ma pozostawić poprzednią wartość.
- Dodaj konstruktor otrzymujący nazwę drukarki i początkową liczbę arkuszy. Przyjmij poprawne argumenty konstruktora.
- Dodaj metodę Print(int pageCount). Jeśli liczba stron jest dodatnia i papieru wystarcza, metoda zmniejsza zapas i zwraca true. W przeciwnym razie zwraca false bez zmiany zapasu. Jedna strona zużywa jeden arkusz.
- Utwórz drukarkę z 10 arkuszami. Do zmiennej selectedPrinter przypisz referencję do tej drukarki. Do osobnej zmiennej typu int skopiuj jej początkową liczbę arkuszy.
- Wczytaj liczbę stron za pomocą Console.ReadLine i int.TryParse. Jeśli konwersja się powiedzie, spróbuj wykonać wydruk przez selectedPrinter i wyświetl wynik operacji. Przy błędnym tekście wyświetl komunikat.
- Wyświetl liczbę arkuszy przez obie zmienne wskazujące drukarkę oraz wcześniej zapisaną liczbę typu int. Wyjaśnij otrzymane wyniki.
*/

using PrinterTaskConsoleApp;


    Printer printer = new Printer("Brother", 10);

    Printer selectedprinter = printer;
    int copiedPaperCount = printer.PaperCount;

    Console.WriteLine("POdaj liczbę stron do wydrukowania: ");


    if (int.TryParse(Console.ReadLine(), out int pageCount))
    {
        bool printResult = selectedprinter.Print(pageCount);

        if (printResult)
        {
            Console.WriteLine("Wydruk się udał");
        }
        else
        {
            Console.WriteLine("Nie można wydrukować.");
        }
    }
    else
    {
        Console.WriteLine("Nieprawidłowa liczba");
    }

    Console.WriteLine("Drukarka: " + printer.Name);
    Console.WriteLine("Liczba arkuszy przez printer: " + printer.PaperCount);
    Console.WriteLine("Liczba arkuszy przez selectedPrinter: " + selectedprinter.PaperCount);
    Console.WriteLine("Kopia liczby arkuszy: " + copiedPaperCount);
