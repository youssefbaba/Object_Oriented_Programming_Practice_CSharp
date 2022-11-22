namespace Exercise_5
{
    public class TestDirectory
    {
        static void Main(string[] args)
        {
            Plug plug1 = new Plug("Amanda Byrd", "(214)771-4611", "info@juvanew.com");
            Plug plug2 = new Plug("Rekha Bhakta", "(903)519-9882", "texaslaserhair@gmail.com");
            Plug plug3 = new Plug("Ida Cassaretto", "(210) 584-3731", "idacassaretto@gmail.com");
            Plug plug4 = new Plug("Eileen Andrews", "(512) 891- 0420", "cocosalonaustin@yahoo.com");
            Plug plug5 = new Plug("Teresa L. Babb", "(242) 142-2546", "info@blushaestheticsandskincare.com");


            Dictionary<string, Plug> dictionary = new Dictionary<string, Plug>();
            dictionary.Add(plug1.Name, plug1);
            dictionary.Add(plug2.Name, plug2);
            dictionary.Add(plug3.Name, plug3);
            dictionary.Add(plug4.Name, plug4);
            dictionary.Add(plug5.Name, plug5);


            foreach (Plug plug in dictionary.Values)
            {
                Console.WriteLine(plug); // Console.WriteLine(plug.ToString());
            }
            Console.WriteLine();


            Directory directory = new Directory(dictionary);


            //directory.FindPlugByName(null);
            //directory.FindPlugByName("Not Found");
            directory.FindPlugByName(plug3.Name);
            Console.WriteLine();


            //directory.AddPlugByName(null);
            //directory.AddPlugByName("NewKey");
            directory.AddPlugByName("Ida Cassaretto");


            Console.WriteLine(directory);  // Console.WriteLine(directory.ToString()); 
        }
    }
}