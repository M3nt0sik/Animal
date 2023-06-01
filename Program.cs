using Animal;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        Animals[] animals = Array.Empty<Animals>();
        for (int i = 0; i < random.Next(1, 11);i++)
        {
            if (i % 2 == 0) { Array.Resize(ref animals, animals.Length + 1); animals[i] = new Hippo(); }
            else { Array.Resize(ref animals, animals.Length + 1); animals[i] = new Wolf(i % 3 == 0); }
        }

        foreach (Animals animal in animals)
        {
            if (animal is Hippo hippo)
            {
                hippo.MakeNoise();
                hippo.Swim();
            }
            else if(animal is Wolf wolf)
            {
                wolf.MakeNoise();
                wolf.HuntInPack();
            }
        }
    }
}