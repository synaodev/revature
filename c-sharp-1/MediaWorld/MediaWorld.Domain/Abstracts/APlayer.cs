using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Abstracts {
	public abstract class APlayer : IPlayer {
		private AMedia stored = null;
		public void Play(AMedia media) {
			if (media != null) {
				if (stored == media) {
					System.Console.WriteLine("The {0} called {1} is currently playing!");
				} else if (stored == null) {
					System.Console.WriteLine("Playing a {0} called {1}!", media.Type, media.Title);
					media = stored;
				}
			} else {
				System.Console.WriteLine("Can't play media!");
			}
		}
		public void Stop() {
			if (stored != null) {
				System.Console.WriteLine("Stopping the {0} called {1}!", stored.Type, stored.Title);
				stored = null;
			} else {
				System.Console.WriteLine("Nothing is playing!");
			}
		}
	}
}