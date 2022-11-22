namespace Exercise_6
{
    public class CitySet
    {
        // Fields
        Dictionary<string, City> _dictionaryCities; // is private by default and in dictionary the key is unique

        // Constructors
        public CitySet()
        {
            _dictionaryCities = new Dictionary<string, City>();
        }
        // Methods
        public City GetCity(string nameCity)
        {
            foreach (string key in _dictionaryCities.Keys)
            {
                if (nameCity == key)
                {
                    return _dictionaryCities[key]; // because key is unique
                }
            }
            return null;
        }
        public void AddCity(City city)
        {
            if (city == null)
            {
                Console.WriteLine("Please city cannot be null !");
            }
            else
            {
                foreach (string key in _dictionaryCities.Keys)
                {
                    if (city.NameCity == key)
                    {
                        Console.WriteLine("City name exists in the dictionaryCities !");
                        return;
                    }
                }
                if (city.NameCity != null)
                {
                    _dictionaryCities.Add(city.NameCity, city);
                }
                else
                {
                    Console.WriteLine("City name cannot be null !");
                }
            }
        }
        public string GetDepartementCode(string nameCity)
        {

            foreach (string key in _dictionaryCities.Keys)
            {
                if (nameCity == key)
                {
                    return _dictionaryCities[nameCity].CodeDepartement;
                }
            }
            return "Not Found";
        }
        public void DisplaySet()
        {
            Dictionary<string, City> ordered = _dictionaryCities.OrderBy(keyValuePair => keyValuePair.Key).ToDictionary(keyItem => keyItem.Key, valueItem => valueItem.Value);
            foreach (KeyValuePair<string, City> keyValuePair in ordered)
            {
                Console.WriteLine($"NameCity = {keyValuePair.Value.NameCity} - CodeDepartement = {keyValuePair.Value.CodeDepartement} - CodeCommune = {keyValuePair.Value.CodeCommune}");
            }
        }
    }
}
