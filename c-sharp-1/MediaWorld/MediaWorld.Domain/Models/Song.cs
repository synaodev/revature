using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models {
	public class Song : AMedia {
		public Song(string title) : base() {
			base.Title = title;	
			base.Type = "Song";
		}
	}
}