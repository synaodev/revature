using System.Xml.Serialization;

namespace MediaWorld.Domain.Abstracts {
	public abstract class AMedia {
		[XmlElement]
		public string Title { get; set; }
		protected AMedia() {
			Title = "Revature";
		}
	}
}