// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Enkel buggövning

int tal1 = 7;
int tal2 = 3;
int tal3 = 6;
int resultat = 0;
resultat = Addition(tal1, tal2);

Console.WriteLine("Resultatet av additionen är: " + resultat);

resultat = Subtraction(tal3, tal1);

Console.WriteLine("Resultatet av subtraktionen är: " + resultat);
resultat = Multiplication(tal1, tal2);

Console.WriteLine("Resultatet av multiplikationen är: " + resultat);
Console.ReadLine();

static int Addition(int a, int b)
{
    return a + b;
}

static int Subtraction(int a, int b)
{
    return a - b;
}
static int Multiplication(int a, int b)
{
    return a * b;
}