using System;

namespace StringManip {
    class Program {
        static void IsVowel(char c) {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y') {
                return true;
            }
            return false;
        }
        static void Run(string data) {
            System.Console.WriteLine("Number of characters: {0}", data.Length);
            int consonants = 0;
            int vowels = 0;
            for (int i = 0; i < data.Length; ++i) {
                char c = data[i];
                if (!char.IsWhiteSpace(c)) {
                    if (IsVowel(c)) {
                        ++vowels;
                    } else {
                        ++consonants;
                    }
                }
            }
            System.Console.WriteLine("Number of consonants: {0}", consonants);
            System.Console.WriteLine("Number of vowels: {0}", vowels);
        }
        static void Main(string[] args) {
            if (args.Length != 0) {
                string data = args[0];
                Run(data);
            } else {
                System.Console.WriteLine("Error! Pass in a string!");
            }
        }
    }
}
