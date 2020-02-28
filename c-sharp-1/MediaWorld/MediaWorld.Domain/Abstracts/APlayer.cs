using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Abstracts {
	public abstract class APlayer : IPlayer {
		public void Play(AMedia media) {
			System.Console.WriteLine("{0} is being played...", media.Title);
		}
		public void Stop(AMedia media) {
			System.Console.WriteLine("{0} is being stopped...", media.Title);
		}
	}
}