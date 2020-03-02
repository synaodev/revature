using System;

namespace Digimon {
    internal class Digimon {}
    internal class Program {
        public static void Fight(Digimon a, Digimon b) {
            System.Console.WriteLine("{0} fights {1}", a, b);
        }
        private static void Main(string[] args) {
            Fight(null, null);
        }
    }
}
