﻿using Animal;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        Animals[] animals = Array.Empty<Animals>();
        for (int i = 0; i < random.Next(1, 11);i++)
        {
            if (random.Next(1, 11) % 2 == 0) { Array.Resize(ref animals, animals.Length + 1); animals[i] = new Hippo(); }
            else { Array.Resize(ref animals, animals.Length + 1); animals[i] = new Wolf(random.Next(1, 11) % 3 == 0); }
        }

        foreach (Animals animal in animals)
        {
            animal.MakeNoise();
            if (animal is ISwimmer hippo)
            {
                hippo.Swim();
            }
            else if(animal is IPackHunter wolf)
            {
                wolf.HuntInPack();
            }
        }
    }
}