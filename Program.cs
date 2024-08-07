
// O herói ataca primeiro.
// Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
// Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
// Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
// Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
// Imprima quem foi o vencedor.

// Monster was damaged and lost 1 health and now has 9 health.
// Hero was damaged and lost 1 health and now has 9 health.
// Monster was damaged and lost 7 health and now has 2 health.
// Hero was damaged and lost 6 health and now has 3 health.
// Monster was damaged and lost 9 health and now has -7 health.
// Hero wins!

int hero = 10;
int monstro = 10;
Random gerador = new Random();
do
{
    int atack = gerador.Next(1, 11);
    monstro -= atack;
    System.Console.WriteLine($"Monster was damaged and lost {atack} health and now has {monstro} health.");
    if (monstro <= 0) continue;

    atack = gerador.Next(1, 11);

    hero -= atack;
    System.Console.WriteLine($"Hero was damaged and lost {atack} health and now has {hero} health.");


} while (hero >= 0 && monstro >= 0);

string ganhador = "";
if (hero > 0) ganhador = "hero";
else ganhador = "monstro";
System.Console.WriteLine($"{ganhador} wins!");