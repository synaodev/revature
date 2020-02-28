using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Storage {
	public class AudioRepository {
		private AMedia[] _arr;
		private List<AMedia> _lib;
		private Dictionary<string, AMedia> _dic;
		public AudioRepository() {
			_arr = new AMedia[] { new Song() };
		}
		public IEnumerable<AMedia> Playlist() {
			return _arr;
		}
	}
}