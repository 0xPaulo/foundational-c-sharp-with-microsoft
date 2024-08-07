
// // O herói ataca primeiro.
// // Imprima a quantidade de integridade que o monster perdeu e a integridade que resta a ele.
// // Se a integridade do monster for maior que zero, ele poderá atacar o herói.
// // Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
// // Continue esta sequência de ataque até que a integridade do monster ou do herói seja zero ou menos.
// // Imprima quem foi o vencedor.


// int hero = 10;
// int monster = 10;
// Random gerador = new Random();
// do
// {
//     int atack = gerador.Next(1, 11);
//     monster -= atack;
//     System.Console.WriteLine($"Monster was damaged and lost {atack} health and now has {monster} health.");
//     if (monster <= 0) continue;

//     int atackMonstro = gerador.Next(1, 11);
//     hero -= atackMonstro;
//     System.Console.WriteLine($"Hero was damaged and lost {atackMonstro} health and now has {hero} health.");


// } while (hero >= 0 && monster >= 0);

// string winner = "";
// if (hero > 0) winner = "hero";
// else winner = "monster";
// System.Console.WriteLine($"{winner} wins!");