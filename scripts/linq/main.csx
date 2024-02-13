//Per fare il debug di questi esempi, devi prima installare il global tool dotnet-script con questo comando:
//dotnet tool install -g dotnet-script
//Trovi altre istruzioni nel file /scripts/readme.md
class Apple {
    public string Color { get; set; }
    public int Weight { get; set; } //In grammi
}

List<Apple> apples = new List<Apple> {
    new Apple { Color = "Red", Weight = 180 },
    new Apple { Color = "Green", Weight = 195 },
    new Apple { Color = "Red", Weight = 190 },
    new Apple { Color = "Green", Weight = 185 },
};

//ESEMPIO #1: Ottengo i pesi delle mele rosse
IEnumerable<int> weightsOfRedApples = apples
                            .Where(apple => apple.Color == "Red")
                            .Select(apple => apple.Weight);

//ESEMPIO #2: Calcolo la media dei pesi ottenuti
double average = weightsOfRedApples.Average();
Console.WriteLine();

//ESERCIZIO #1: Qual è il peso minimo delle 4 mele?
int minimumWeight = apples.Min(apple => apple.Weight);
Console.WriteLine(minimumWeight);

//ESERCIZIO #2: Di che colore è la mela che pesa 190 grammi?
string color = (apples.Where(apple => apple.Weight == 190)
                     .Select(apple => apple.Color)).FirstOrDefault();

Console.WriteLine(color);

//ESERCIZIO #3: Quante sono le mele rosse?
int redAppleCount = apples.Count(apple => apple.Color == "Red");
Console.WriteLine(redAppleCount);

//ESERCIZIO #4: Qual è il peso totale delle mele verdi?
int totalWeight = apples.Where(apple => apple.Color == "Green")
                        .Sum(apple => apple.Weight);
Console.WriteLine(totalWeight);
