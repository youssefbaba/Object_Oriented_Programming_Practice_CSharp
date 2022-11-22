namespace Exercise_6
{
    public class City
    {
        // Constructors
        public City(string nameCity, string codeDepartement, string codeCommune)
        {
            NameCity = nameCity;
            CodeDepartement = codeDepartement;
            CodeCommune = codeCommune;
        }


        // Properties
        public string NameCity { get; private set; }
        public string CodeDepartement { get; private set; }
        public string CodeCommune { get; private set; }
    }
}
