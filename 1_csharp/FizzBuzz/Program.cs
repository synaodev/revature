using System;

namespace FizzBuzz {
	class Program {
		static void Run(int number) {
			for (int i = 0; i < number; ++i) {
				bool written = false;
				if (i % 3 == 0) {
					written = true;
					System.Console.Write("Fizz");
				} 
				if (i % 5 == 0) {
					written = true;
					System.Console.Write("Buzz");
				}
				if (written) {
					written = false;
					System.Console.Write('\n');
				}
			}
		}
		static void Main(string[] args) {
			if (args.Length != 0) {
				try {
					int number = Int32.Parse(args[0]);
					Run(number);
				} catch (FormatException) {
					System.Console.WriteLine("Error! Format exception!");
				} catch (Exception ex) {
					throw new Exception("Error!", ex);
				} finally {
					GC.Collect();
				}
			} else {
				System.Console.WriteLine("Error! You need to input a number!");
			}
		}
	}
}
