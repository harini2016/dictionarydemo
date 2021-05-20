using System;
using System.Collections.Generic;

namespace dictionarydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> myDictionary = new List<KeyValuePair<string, string>>();

            myDictionary.Add(new KeyValuePair<string, string>("foo", "bar"));
            myDictionary.Add(new KeyValuePair<string, string>("foo", "bad"));

            Console.WriteLine("Please enter a command: ");
            Console.WriteLine("KEYS");
            Console.WriteLine("ADD");
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
                    case "KEYS":
                        ListAllKeys(myDictionary);
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
    }

}
