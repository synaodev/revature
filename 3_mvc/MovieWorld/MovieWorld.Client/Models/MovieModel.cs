using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieWorld.Client.Models;

namespace MovieWorld.Client.Models {
	public class MovieModel {
		[Required]
		[StringLength(150)]
		public string Title { get; set; }
		[Required(ErrorMessage = "Please fill out a genre")]
		[DataType(DataType.Text)]
		public string Genre { get; set; }
	}
}