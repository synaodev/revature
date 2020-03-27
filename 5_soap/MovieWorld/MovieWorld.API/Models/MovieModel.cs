using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWorld.API.Models {
	public class MovieModel {
		public long MovieID { get; set; }
		[Required]
		public string Title { get; set; }
		public MovieModel() {
			MovieID = DateTime.Now.Ticks;
		}
	}
}