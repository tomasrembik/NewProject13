// zadanie 5

Console.WriteLine("  Podaj liczbe");

var number = Console.ReadLine();

Console.WriteLine("  OK To liczymy");
Console.WriteLine("-----------------------------------------");

List<string> numbers = new List<string>();

char[] letters = number.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}

Console.WriteLine(" w liczbie " + number );
Console.WriteLine(" liczba 0 " + " występje " + counter0 + " razy ");
Console.WriteLine(" liczba 1 " + " występje " + counter1 + " razy ");
Console.WriteLine(" liczba 2 " + " występje " + counter2 + " razy ");
Console.WriteLine(" liczba 3 " + " występje " + counter3 + " razy ");
Console.WriteLine(" liczba 4 " + " występje " + counter4 + " razy ");
Console.WriteLine(" liczba 5 " + " występje " + counter5 + " raz ");
Console.WriteLine(" liczba 6 " + " występje " + counter6 + " razy ");
Console.WriteLine(" liczba 7 " + " występje " + counter7 + " razy ");
Console.WriteLine(" liczba 8 " + " występje " + counter8 + " razy ");
Console.WriteLine(" liczba 9 " + " występje " + counter9 + " razy ");

Console.ReadKey();