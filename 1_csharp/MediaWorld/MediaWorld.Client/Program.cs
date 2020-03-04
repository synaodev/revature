using System;
using System.Linq;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons; 
using MediaWorld.Storage.Adapters; 
using MediaWorld.Storage.Repositories;

namespace MediaWorld.Client {
    internal class Program {
        private static readonly AudioRepository _ar = new AudioRepository();
        private static void Main(string[] args) {
            PlayBook();
        }
        private static void PlayBook() {
            var b = new Book();
            // b.Read(HowToRead.Upper);
            // b.ReadAction((string s) => { Console.WriteLine(s.ToLowerInvariant()); });
            // b.ReadFunction((string s) => { Console.WriteLine(s.ToUpperInvariant()); return string.Empty; });
            // b.ReadDelegate((string s) => { Console.WriteLine(s.ToLowerInvariant()); });
            // b.ReadDelegate(UseCasingDelegate);
            // b.ReadDelegate2(UseCasingDelegate2);
            // event
            b.Open();
            b.BookEvent += UseEvent;
        }
        public static void UseEvent(string s) {
            Console.WriteLine(s);
        }
        private static void UseCasingDelegate(string s) {
            Console.WriteLine(s);
        }
        private static string UseCasingDelegate2() {
            return "delegate rules!!!";
        }
        private static void PlayAudio() {
            var ap = AudioPlayer.Instance;
            var ac = new AudioRepository();
            var ac2 = new AudioRepositoryGeneric<Song>();
            var ac3 = new AudioRepositoryGeneric<Book>();
            try { 
                foreach (var item in ac.List()) {
                    ap.Play(item);
                }
            } catch (NullReferenceException ex) {
                Console.WriteLine(ex.Message);
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            } catch (Exception ex) {
                throw new Exception("Error!", ex);
            } finally {
                GC.Collect();
            }
        }
    }
}