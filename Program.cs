using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionarydemo
{

    class KeyValue {
        public Dictionary<int, KeyValuePair<string, string>> Dictionary = new Dictionary<int, KeyValuePair<string, string>>();
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> myDictionary = new List<KeyValuePair<string, string>>();

            Console.WriteLine("Please enter an option from below: ");
            Console.WriteLine("ADD");
            Console.WriteLine("KEYS");
            Console.WriteLine("MEMBERS");
            Console.WriteLine("KEYEXISTS");
            Console.WriteLine("VALUEEXISTS");
            Console.WriteLine("REMOVE");
            Console.WriteLine("REMOVEALL");
            Console.WriteLine("CLEAR");
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
                        Console.WriteLine("Please enter key and value you want to remove");
                        RemoveMember(myDictionary);
                        break;
                    case "REMOVEALL":
                        Console.WriteLine("Please enter key and value you want to remove");
                        //RemoveMemberandKey(myDictionary);
                        break;
                    case "CLEAR":
                        ClearMembers(myDictionary);
                        break;
                    case "KEYEXISTS":
                        Console.WriteLine("Please enter key want to check");
                        KeyExists(myDictionary);
                        break;
                    case "VALUEEXISTS":
                        Console.WriteLine("Please enter key want to check");
                        KeyExists(myDictionary);
                        break;
                    case "KEYS":
                        ListAllKeys(myDictionary);
                        break;
                    case "MEMBERS":
                        Console.WriteLine("Please enter key to list the members");
                        ListValuesForKeys(myDictionary);
                        break;
                    case "ALLMEMBERS":
                        ListAllValues(myDictionary);
                        break;
                    case "ITEMS":
                        ListKeyValuePairs(myDictionary);
                        break;
                    case "EXIT":
                        break;
                    default:
                        Console.WriteLine("Unknown option chosen.  Please enter valid option:");
                        break;
                }
            } 
        }
        public static void AddOrUpdateMember(List<KeyValuePair<string, string>> dict)
        {
            string inputValues = Console.ReadLine();
            string[] input = inputValues.Split(" ");

            KeyValuePair<string, string> newValue = new KeyValuePair<string, string>(input[0], input[1]);
            newValue.ToString();

            foreach (KeyValuePair<string, string> kvp in dict) {
                if(kvp.Value == newValue.Value) {
                    Console.WriteLine("ERROR, value already exists");
                    return;
                }
            }
            dict.Add(newValue);
            Console.WriteLine("ADDED");
        }
        
        public static void KeyExists(List<KeyValuePair<string, string>> dict)
        {
            string inputValue = Console.ReadLine();

            foreach (KeyValuePair<string, string> kvp in dict) {
                if(kvp.Key == inputValue) {
                    Console.WriteLine(true);
                    return;
                } else {
                    Console.WriteLine(false);
                    return;
                }
            }
        }

        public static void ValueExists(List<KeyValuePair<string, string>> dict)
        {
            string inputValue = Console.ReadLine();

            foreach (KeyValuePair<string, string> kvp in dict) {
                if(kvp.Value == inputValue) {
                    Console.WriteLine(true);
                    return;
                } else {
                    Console.WriteLine(false);
                    return;
                }
            }
        }

        public static void ClearMembers(List<KeyValuePair<string, string>> dict)
        {
            dict.Clear();
            Console.WriteLine("CLEARED");
        }

        public static void RemoveMember(List<KeyValuePair<string, string>> dict)
        {
            string inputValues = Console.ReadLine();
            string[] input = inputValues.Split(" ");

            KeyValuePair<string, string> newValue = new KeyValuePair<string, string>(input[0], input[1]);

            foreach (KeyValuePair<string, string> kvp in dict) {
                if(kvp.Value == newValue.Value && kvp.Key == newValue.Key) {
                    dict.Remove(newValue);
                    Console.WriteLine("REMOVED");
                    return;
                }
            }

        }

        public static void ListAllKeys(List<KeyValuePair<string, string>> dict)
        {
            // if no values/keys in dict execute this condition
            if(dict.Count == 0) {
                Console.WriteLine("empty set");
                return;
            }

            List<string> allKeys = (from kvp in dict select kvp.Key).Distinct().ToList();
            // Get and display keys
            var i=0;
            foreach (string key in allKeys)
            {
                i++;
                Console.WriteLine("{0}) {1}", i, key);
            }

        }
        public static void ListAllValues(List<KeyValuePair<string, string>> dict)
        {
            // Get and display values
            var i=0;
            foreach (KeyValuePair<string, string> pair in dict)
            {
                i++;
                Console.WriteLine("{0}) {1}", i, pair.Value);
            }
        }

        // Prints all values for keys
        public static void ListValuesForKeys(List<KeyValuePair<string, string>> dict)
        {
            if (dict.Count == 0)
            {
                Console.WriteLine("empty set");
                return;
            }
            string keyName = Console.ReadLine();

            List<string> values = (from kvp in dict where kvp.Key == keyName select kvp.Value).ToList();

            var i=0;
            foreach(string val in values) {
                i++;
                Console.WriteLine("{0}) {1}", i, val);
            }
        }
        
        // Prints all key value pairs
        public static void ListKeyValuePairs(List<KeyValuePair<string, string>> dict)
        {
            if(dict.Count == 0) {
                Console.WriteLine("empty set");
                return;
            }
            // Get and display all key value pairs
            KeyValuePair<string, string>[] result;
            result = dict.ToArray();
            var i = 0;
            if(result != null) {
                foreach (KeyValuePair<string, string> pair in result)
                {
                    i++;
                    Console.WriteLine("{0}) {1}: {2}", i, pair.Key, pair.Value);
                }
            } 

        }
    }
}
