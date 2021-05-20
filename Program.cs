using System;
using System.Collections.Generic;

namespace dictionarydemo
{
    class Program
    {

        public static void AddOrUpdateMember(List<KeyValuePair<string, string>> dict)
        {
            string inputValues = Console.ReadLine();
            string[] input = inputValues.Split(" ");
            //dict.Add(input[0], input[1]);
            Console.WriteLine("KEY {0}, VALUE {1}", input[0], input[1]);

            KeyValuePair<string, string> newValue = new KeyValuePair<string, string>(input[0], input[1]);

            foreach (KeyValuePair<string, string> kvp in dict) {
                if(kvp.Value == newValue.Value) {
                    Console.WriteLine("ERROR, value already exists");
                    return;
                }
            }
            dict.Add(newValue);  
            ListKeyValuePairs(dict);
        }
        static void Main(string[] args)
        {
            bool useSampleData = true;
            List<KeyValuePair<string, string>> myDictionary = new List<KeyValuePair<string, string>>();

            myDictionary.Add(new KeyValuePair<string, string>("foo", "bar"));
            myDictionary.Add(new KeyValuePair<string, string>("foo", "bad"));
            // myDictionary.Add(new KeyValuePair<string, string>("bar", "bang"));
            // myDictionary.Add(new KeyValuePair<string, string>("bang", "ball"));

            // Dictionary<string, List<string>> myDictionary= new Dictionary<string, List<string>>();

            // myDictionary.Add("foo", "bar");
            // myDictionary.Add("bar", "band");
            // myDictionary.Add("bar", "band");

            Console.WriteLine("Please enter a command: ");
            Console.WriteLine("KEYS");
            Console.WriteLine("MEMBERS");
            Console.WriteLine("ADD");
            Console.WriteLine("REMOVE");
            Console.WriteLine("REMOVEALL");
            Console.WriteLine("CLEAR");
            Console.WriteLine("KEYEXISTS");
            Console.WriteLine("VALUEEXISTS");
            Console.WriteLine("ALLMEMBERS");
            Console.WriteLine("ITEMS");

            while (true)
            {
                string command;
                command = Console.ReadLine().ToUpper();

                switch (command)
                {
                    case "ADD":
                        Console.WriteLine("Please enter key value pair");
                        AddOrUpdateMember(myDictionary);
                        break;
                    case "REMOVE":
                        Console.WriteLine("Please enter key you want to remove");
                        //RemoveMember(myDictionary);
                        break;
                    case "REMOVEALL":
                        Console.WriteLine("Please enter key you want to remove");
                        //RemoveMemberandKey();
                        break;
                    case "CLEAR":
                        //ClearMembers();
                        break;
                    case "KEYS":
                        ListAllKeys(myDictionary);
                        break;
                    case "MEMBERS":
                        //ListValuesForKeys(myDictionary);
                        break;
                    case "ALLMEMBERS":
                        ListAllValues(myDictionary);
                        break;
                    case "ITEMS":
                        ListKeyValuePairs(myDictionary);
                        break;
                }
            } 
        }

        // public static void ListValuesForKeys(List<KeyValuePair<string, string>> dict)
        // {
        //     Console.WriteLine("Please enter a key");
        //     string inputKey = Console.ReadLine();
        //     // Get and display values  

        //     dict.Select(KeyValuePair => KeyValuePair.Key);
        //     foreach (KeyValuePair<string, string> pair in dict[inputkey])
        //     {
        //         // foreach (string key in pair.Key where )
        //         // {
        //                 Console.WriteLine("Values for the key", pair.Value);
        //         //}
        //     }
        // }

        public static void ListAllKeys(List<KeyValuePair<string, string>> dict)
        {
            // Get and display keys  
            foreach (KeyValuePair<string, string> pair in dict)
            {
                Console.WriteLine("KEY :{0}", pair.Key);
            }
        }
        public static void ListAllValues(List<KeyValuePair<string, string>> dict)
        {
            // Get and display values  
            foreach (KeyValuePair<string, string> pair in dict)
            {
                Console.WriteLine("Values :{0}", pair.Value);
            }
        }

        public static void ListKeyValuePairs(List<KeyValuePair<string, string>> dict)
        {
            // Get and display all key value pairs  
            foreach(KeyValuePair<string, string> pair in dict)
            {
                Console.WriteLine("Key: {0} , Value :{1}", pair.Key, pair.Value);
            }
        }

        // public static void RemoveMember(List<KeyValuePair<string, string>> dict)
        // {
        //     string key = Console.ReadLine();
        //     foreach(KeyValuePair<string, string> pair in dict)
        //     {
        //         dict.Remove(pair);
        //         Console.WriteLine("Key: {0} , Value :{1}", pair.Key, pair.Value);
        //     }
        //     ListKeyValuePairs(dict);
        // }
    }

}
