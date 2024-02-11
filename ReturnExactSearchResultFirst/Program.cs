using ReturnExactSearchResultFirst;

// Data uit de DB
List<City> returnedFromDatabase = new()
{
    new City { Id = 1, Name = "Bakhuizen"},
    new City { Id = 2, Name = "Elahuizen"},
    new City { Id = 3, Name = "Achthuizen"},
    new City { Id = 4, Name = "Benthuizen"},
    new City { Id = 5, Name = "Driehuizen"},
    new City { Id = 6, Name = "Broekhuizen(DR)"},
    new City { Id = 7, Name = "Broekhuizen(LB)"},
    new City { Id = 8, Name = "Broekhuizenvorst"},
    new City { Id = 9, Name = "Biddinghuizen" },
    new City { Id = 10, Name = "Delfstrahuizen"},
    new City { Id = 11, Name = "Huizen" },
};

// Invoer van de gebruiker, voor dit voorbeeld een vaste waarde.
string userInput = "huiz";

// Een manier om de invoer van de gebruiker te controleren om SQL injection / andere rare dingen te voorkomen.
// Voor dit simpele voorbeeld simpelweg hetzelfde als de invoer.
string keyword = userInput;

// Sorteert door namen die met de gevalideerde input beginnen aan het begin te zetten, de rest daarna alfabetisch.
List<City> sortedResult = returnedFromDatabase
    .OrderByDescending(c => c.Name.ToLower().StartsWith(keyword.ToLower()))
    .ThenBy(c => c.Name)
    .ToList();

// Dit is een console app, zo kan ik de eerste 10 printen.
for (int count = 0; count < 10; count++)
{
    Console.WriteLine(sortedResult[count].Name);
}



