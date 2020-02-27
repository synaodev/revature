using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Domain.Singletons {
	public class AudioPlayer : APlayer {
		private static AudioPlayer inst = new AudioPlayer();
		private AudioPlayer() {}
		public static AudioPlayer Instance {
			get { return inst; }
		}
		public void PlayAudio(Song song) {
			this.Play(song);
		}
		public void PlayAudio(Book book) {
			this.Play(book);
		}
	}
}