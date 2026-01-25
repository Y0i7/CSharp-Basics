/*
Juego de dados que simula la batalla entre un heroe y un monstruo,
el heroe atacará y el monstruo contra atacara si su salud es mayor a 0
se mostrará por pantalla el daño que cada uno recibe y la salud restante.
El juego finaliza una vez la salud de alguno de los dos personajes llega a 0
mostrando por pantalla al ganador.
*/

var dice = new Random();

int damagePoints;

var heroHealtPoints = 10;
var monsterHealtPoints = 10;

do
{
    damagePoints = dice.Next(0, 11);
    monsterHealtPoints -= damagePoints;

    Console.WriteLine($"Monster takes {damagePoints} of damage\nHealt remaining: {monsterHealtPoints}");

    if (monsterHealtPoints > 0)
    {
        damagePoints = dice.Next(0, 11);
        heroHealtPoints -= damagePoints;

        Console.WriteLine($"Hero takes {damagePoints} of damage\nHealt remaining: {heroHealtPoints}");

    }

} while ((heroHealtPoints > 0) & (monsterHealtPoints > 0));

Console.WriteLine(heroHealtPoints > monsterHealtPoints ? "Hero Wins!" : "Monster Wins");