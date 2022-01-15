int x = 16;
int y = 8;

int rezultat;

/*
AND  -- i  -- &&
a    b      a AND b
F    F         F
F    T         F
T    F         F
T    T         T

OR -- ili  -- ||
a    b      a OR b
F    F         F
F    T         T
T    F         T
T    T         T

NOT -- negacija -- !
a          !a

F           T
T           F
*/

x = 3;
y = 128;
if (x % 2 == 0 && x > 10 || y == 128)
{
    Console.WriteLine(x + " je paran broj");
}

int bbroj = 8;

switch (bbroj)
{
    case 5:
        Console.WriteLine("Pet je");
        break;

    case 6:
        Console.WriteLine("Sest je");
        break;

    case 7:
        Console.WriteLine("Sedam je");
        break;

    case 8:
        Console.WriteLine("Osam je");
        break;

    default:
        Console.WriteLine("Nznm :/");
        break;
}

int broj = 5;

broj = broj + 2;
broj += 2;
broj *= 5;

broj += 1;
broj++;
broj--;

broj = 1;

while (broj < 100)
{
    broj++;
    if (broj % 2 == 1)
    {
        continue;
    }

    Console.WriteLine(broj);
    if (broj == 64)
    {
        break;
    }
}

//Tipovi while petlje
int primer = 10;
while (primer > 100)
{
    Console.WriteLine(primer + " je veci od 100");
    primer--;
}

do
{
    Console.WriteLine(primer + " je veci od 100");
    primer--;
} while (false);

//For
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("i je sada " + i);
}

Console.WriteLine("Gotovooooo");