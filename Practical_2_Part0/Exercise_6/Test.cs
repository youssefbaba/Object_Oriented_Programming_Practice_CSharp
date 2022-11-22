namespace Exercise_6
{
    public class Test
    {
        static void Main(string[] args)
        {
            CitySet citySet = new CitySet();
            City city1 = new City("New York", "123", "NY");
            City city2 = new City("California", "452", "CA");
            City city3 = new City("Los Angeles", "486", "LA");
            citySet.AddCity(city1);
            citySet.AddCity(city2);
            citySet.AddCity(city3);
            citySet.DisplaySet();
            Console.WriteLine();


            City city4 = new City("Los Angeles", "478", "LA");
            citySet.AddCity(city4);  // City name exists in the dictionaryCities !
            citySet.DisplaySet();
            Console.WriteLine();


            City city5 = null;
            citySet.AddCity(city5);  // Please city cannot be null !
            citySet.DisplaySet();
            Console.WriteLine();


            City city9 = new City(null, "486", "MX");
            citySet.AddCity(city9);   // City name cannot be null !
            citySet.DisplaySet();
            Console.WriteLine();


            City city6 = citySet.GetCity("California");
            //City city7 = citySet.GetCity("Califo");
            //City city8 = citySet.GetCity(null);
            if (city6 != null)
            {
                Console.WriteLine($"NameCity = {city6.NameCity} - CodeDepartement = {city6.CodeDepartement} - CodeCommune = {city6.CodeCommune}");
                //Console.WriteLine($"NameCity = {city7.NameCity} - CodeDepartement = {city7.CodeDepartement} - CodeCommune = {city7.CodeCommune}");
                //Console.WriteLine($"NameCity = {city8.NameCity} - CodeDepartement = {city8.CodeDepartement} - CodeCommune = {city8.CodeCommune}");
            }
            else
            {
                Console.WriteLine("City is null");
            }


            Console.WriteLine($"Code Departement = {citySet.GetDepartementCode("Los Angeles")}");
            Console.WriteLine($"Code Departement = {citySet.GetDepartementCode("Los ")}");
        }
    }
}