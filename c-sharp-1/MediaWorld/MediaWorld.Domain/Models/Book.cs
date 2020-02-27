using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models {
	public class Book : AMedia {
		public Book(string title) : base() {
			base.Title = title;	
			base.Type = "Book";
		}
	}
}