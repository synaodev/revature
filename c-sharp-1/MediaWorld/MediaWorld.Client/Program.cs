using MediaWorld.Domain.Singletons;
using MediaWorld.Domain.Models;

namespace MediaWorld.Client {
    internal class Program {
        private static void Main(string[] args) {
            Program.PlayAudio();
            Program.PlayVideo();
        }
        private static void PlayAudio() {
            Book book = new Book("Book A");
            Song song = new Song("Song A");
            AudioPlayer.Instance.PlayAudio(book);
            AudioPlayer.Instance.PlayAudio(song);
        }
        private static void PlayVideo() {
            Movie movie = new Movie("Movie A");
            Photo photo = new Photo("Photo A");
            VideoPlayer.Instance.PlayVideo(movie);
            VideoPlayer.Instance.PlayVideo(photo);
        }
    }
}
