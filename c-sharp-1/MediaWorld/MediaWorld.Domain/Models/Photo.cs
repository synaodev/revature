using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models {
	public class Photo : AMedia {
		public Photo(string title) : base() {
			base.Title = title;	
			base.Type = "Photo";
		}
	}
}