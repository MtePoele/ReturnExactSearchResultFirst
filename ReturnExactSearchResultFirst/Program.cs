using ReturnExactSearchResultFirst;

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
    new Company { Id = 9, City = "Biddinghuizen"},
    new Company { Id = 10, City = "Delfstrahuizen"},
    new Company { Id = 11, City = "Huizen"},
    new Company { Id = 20, City = "Amsterdam"},
    new Company { Id = 25, City = "Panningen"}
};

string keyword = "huiz";

List<Company> sortedresult = returnedFromDatabase
    .Where(c => c.City.ToLower().Contains(keyword.ToLower()))
    .OrderByDescending(c => c.City.ToLower().StartsWith(keyword.ToLower()))
    .ThenBy(c => c.City.ToLower())
    .ToList();

for (int count = 0; count < 10; count++)
{
    Console.WriteLine(sortedresult[count].City);
}



