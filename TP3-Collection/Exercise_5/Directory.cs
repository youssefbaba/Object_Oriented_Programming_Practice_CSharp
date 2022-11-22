namespace Exercise_5
{
    public class Directory
    {
        // Fields
        Dictionary<string, Plug> _dictionary;


        // Constructors
        public Directory(Dictionary<string, Plug> dic)
        {
            _dictionary = dic;
        }


        // Methods
        public void FindPlugByName(string name)
        {
            // Method One
            //if (name != null)
            //{
            //    foreach (string key in _dictionary.Keys)  // key of dictionnary is unique
            //    {
            //        if (name == key)
            //        {
            //            Console.WriteLine($"Name = {_dictionary[key].Name} - Phone = {_dictionary[key].Phone} - Address = {_dictionary[key].Address}");
            //            return;
            //        }
            //    }
            //    Console.WriteLine("Execuse Me This Plug Not Found !");
            //}
            //else
            //{
            //    Console.WriteLine("Please the name of plug must be not null !");
            //}


            // Method Two 
            try
            {
                if (_dictionary.ContainsKey(name))
                {
                    Console.WriteLine($"Name = {_dictionary[name].Name} - Phone = {_dictionary[name].Phone} - Address = {_dictionary[name].Address}");
                    return;
                }
                Console.WriteLine("Execuse Me This Plug Not Found !");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please the name of plug must be not null !");
            }
        }
        public void AddPlugByName(string name)
        {
            // Method One
            //if (name != null)
            //{
            //    foreach (string key in _dictionary.Keys)  // key of dictionnary is unique
            //    {
            //        if (name == key)
            //        {
            //            string entredValue = default;
            //            do
            //            {
            //                Console.Write("Do you want to modify the existing plug ? YES-NO : ");
            //                entredValue = Console.ReadLine();
            //                if (entredValue.ToLower() != "yes" && entredValue.ToLower() != "no")
            //                {
            //                    Console.WriteLine("Please try to enter a valid answer YES-NO");
            //                }
            //                else
            //                {
            //                    if (entredValue.ToLower() == "yes")
            //                    {
            //                        Console.Write("Please enter the new name of this plug : ");
            //                        string modifiedNamePlug = Console.ReadLine();
            //                        Console.Write("Please enter the new phone of this plug : ");
            //                        string modifiedPhonePlug = Console.ReadLine();
            //                        Console.Write("Please enter the new address of this plug : ");
            //                        string modifiedAddessPlug = Console.ReadLine();
            //                        _dictionary.Remove(name);
            //                        Plug modifiedPlug = new Plug(modifiedNamePlug, modifiedPhonePlug, modifiedAddessPlug);
            //                        _dictionary.Add(name, modifiedPlug);
            //                    }
            //                }
            //            } while (entredValue.ToLower() != "yes" && entredValue.ToLower() != "no");
            //            return;
            //        }
            //    }
            //    Console.Write("Please enter the name of the plug : ");
            //    string NewnamePlug = Console.ReadLine();
            //    Console.Write("Please enter the phone of the plug : ");
            //    string NewphonePlug = Console.ReadLine();
            //    Console.Write("Please enter the address of the plug : ");
            //    string NewaddessPlug = Console.ReadLine();
            //    Plug newPlug = new Plug(NewnamePlug, NewphonePlug, NewaddessPlug);
            //    _dictionary.Add(name, newPlug);
            //}
            //else
            //{
            //    Console.WriteLine("Please the name of plug must be not null !");
            //}


            // Method Two
            try
            {
                if (!_dictionary.ContainsKey(name))
                {
                    Console.Write("Please enter the name of the plug : ");
                    string newNamePlug = Console.ReadLine();
                    Console.Write("Please enter the phone of the plug : ");
                    string newPhonePlug = Console.ReadLine();
                    Console.Write("Please enter the address of the plug : ");
                    string newAddessPlug = Console.ReadLine();
                    Plug newPlug = new Plug(newNamePlug, newPhonePlug, newAddessPlug);
                    _dictionary.Add(name, newPlug);
                }
                else
                {
                    string entredValue = default;
                    do
                    {
                        Console.Write("Do you want to modify the existing plug ? YES-NO : ");
                        entredValue = Console.ReadLine();
                        if (entredValue.ToLower() != "yes" && entredValue.ToLower() != "no")
                        {
                            Console.WriteLine("Please try to enter a valid answer YES-NO");
                        }
                        else
                        {
                            if (entredValue.ToLower() == "yes")
                            {
                                Console.Write("Please enter the new name of this plug : ");
                                string modifiedNamePlug = Console.ReadLine();
                                Console.Write("Please enter the new phone of this plug : ");
                                string modifiedPhonePlug = Console.ReadLine();
                                Console.Write("Please enter the new address of this plug : ");
                                string modifiedAddessPlug = Console.ReadLine();
                                _dictionary.Remove(name);
                                Plug modifiedPlug = new Plug(modifiedNamePlug, modifiedPhonePlug, modifiedAddessPlug);
                                _dictionary.Add(name, modifiedPlug);
                            }
                        }
                    } while (entredValue.ToLower() != "yes" && entredValue.ToLower() != "no");
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please the name of plug must be not null !");
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (string key in _dictionary.Keys)
            {
                result += $"\nName = {_dictionary[key].Name} - Phone = {_dictionary[key].Phone} - Address = {_dictionary[key].Address}";
            }
            return result;
        }
    }
}
