using System;

class Dice
{
    private int sides;
    private Random random;

    public Dice(int sides)
    {
        this.sides = sides;
        this.random = new Random();
    }

    public int Roll()
    {
        return random.Next(1, sides + 1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of sides for Dice: ");
        int sides = int.Parse(Console.ReadLine());
        Dice dice = new Dice(sides);

        Console.WriteLine("Guess the number rolled: ");
        int guess = int.Parse(Console.ReadLine());

        int result = dice.Roll();
        Console.WriteLine("The number rolled is: " + result);

        if (guess == result)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}