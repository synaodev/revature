using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieWorld.API.Models;

namespace MovieWorld.API.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class MovieController : ControllerBase {
		private static readonly List<MovieModel> _mml = new List<MovieModel>();
		[HttpGet]
		public IActionResult Get() {
			if (_mml.Count == 0) {
				MovieModel model = new MovieModel() { Title = "Notre Dame" };
				return Ok(model);
			}
			return Ok(_mml);
		}
		// [HttpGet]
		// public IActionResult Get(long ID) {
		// 	MovieModel result = _mml.Find(m => m.MovieID == ID);
		// 	if (result != null) {
		// 		return Ok(result);
		// 	}
		// 	return NotFound(ID);
		// }
		[HttpPost]
		public IActionResult Post(MovieModel model) {
			if (ModelState.IsValid) {
				_mml.Add(model);
				return Ok();
			}
			return BadRequest("Invalid Model! Couldn't Post!");
		}
		[HttpPut]
		public IActionResult Put(MovieModel model) {
			if (ModelState.IsValid) {
				MovieModel existing = _mml.Find(m => m.MovieID == model.MovieID);
				if (existing != null) {
					existing = model;
					return Ok();
				} else {
					return NotFound(model.MovieID);
				}
			}
			return BadRequest("Invalid Model! Couldn't Put!");
		}
		[HttpDelete]
		public IActionResult Delete(long ID) {
			MovieModel model = _mml.Find(m => m.MovieID == ID);
			if (model != null) {
				if (_mml.Remove(model)) {
					return Ok();
				} else {
					return BadRequest("Invalid Model! Couldn't Remove!");
				}
			}
			return NotFound(ID);
		}
	}
}