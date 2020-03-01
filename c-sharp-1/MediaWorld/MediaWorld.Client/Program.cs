using System;
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
            b.Read(HowToRead.Upper);
            b.ReadAction((string s) => { Console.WriteLine(s.ToLowerInvariant()); });
            b.ReadFunction((string s) => { Console.WriteLine(s.ToUpperInvariant()); return string.Empty; });
            b.ReadDelegate((string s) => { Console.WriteLine(s.ToLowerInvariant()); });
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
            } catch (NullReferenceException) {
                Console.WriteLine("NO Playlist for you");
            } catch (IndexOutOfRangeException) {
                Console.WriteLine("NO song for you");
            } catch (Exception err) {
                throw new Exception("error", err);
            } finally {
                GC.Collect();
            }
        }
    }
}