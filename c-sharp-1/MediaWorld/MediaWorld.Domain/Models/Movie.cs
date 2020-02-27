using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models {
	public class Movie : AMedia {
		public Movie(string title) : base() {
			base.Title = title;	
			base.Type = "Movie";
		}
	}
}