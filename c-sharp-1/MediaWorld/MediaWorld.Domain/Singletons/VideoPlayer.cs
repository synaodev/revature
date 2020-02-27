using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Domain.Singletons {
	public class VideoPlayer : APlayer {
		private static VideoPlayer inst = new VideoPlayer();
		private VideoPlayer() {}
		public static VideoPlayer Instance {
			get { return inst; }
		}
		public void PlayVideo(Movie movie) {
			this.Play(movie);
		}
		public void PlayVideo(Photo photo) {
			this.Play(photo);
		}
	}
}