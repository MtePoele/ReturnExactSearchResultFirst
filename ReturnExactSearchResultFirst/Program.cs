using ReturnExactSearchResultFirst;

// Data uit de DB
List<Company> returnedFromDatabase = new()
{
    new Company { Id = 1, City = "Bakhuizen"},
    new Company { Id = 2, City = "Elahuizen"},
    new Company { Id = 3, City = "Achthuizen"},
    new Company { Id = 4, City = "Benthuizen"},
    new Company { Id = 5, City = "Driehuizen"},
    new Company { Id = 6, City = "Broekhuizen(DR)"},
    new Company { Id = 7, City = "Broekhuizen(LB)"},
    new Company { Id = 8, City = "Broekhuizenvorst"},
    new Company { Id = 9, City = "almere"},
    new Company { Id = 10, City = "Delfstrahuizen"},
    new Company { Id = 11, City = "almelo"},
};

// user input, voor dit voorbeeld hardcoded
string keyword = "alm";

// sorteert door namen die beginnen met de user input aan het begin te zetten, de rest daarna alfabetisch
List<Company> sortedresult = returnedFromDatabase
    .OrderByDescending(c => c.City.ToLower().StartsWith(keyword.ToLower()))
    .ThenBy(c => c.City)
    .ToList();

// dit is een console app, zo kan ik de eerste 10 printen
for (int count = 0; count < 2; count++)
{
    Console.WriteLine(sortedresult[count].City);
}



