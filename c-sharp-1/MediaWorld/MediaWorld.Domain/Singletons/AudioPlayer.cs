using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Singletons {
	public class AudioPlayer : APlayer {
		private static AudioPlayer _ap = new AudioPlayer();
		private AudioPlayer() {}
		public static AudioPlayer Instance {
			get { return _ap; }
		}
	}
}