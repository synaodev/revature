using System;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storage.Adapters;
using MediaWorld.Storage.Repositories;

namespace MediaWorld.Client {
    internal class Program {
        private static readonly AudioRepository _ar = new AudioRepository();
        private static void Main(string[] args) {
            PlayAudio();
        }
        private static void PlayAudio() {
            var ap = AudioPlayer.Instance;
            var ac = new AudioRepository();
            try {
                foreach (var item in ac.List()) {
                    ap.Play(item);
                }
            } catch (NullReferenceException) {
                System.Console.WriteLine("No playlist for you!");
            } catch (IndexOutOfRangeException) {
                System.Console.WriteLine("No song for you!");
            } catch (Exception err) {
                throw new Exception("error", err);
            } finally {
                GC.Collect();
            }
        }
    }
}
