namespace MediaWorld.Domain.Abstracts {
	public abstract class AMedia {
		public string Title { get; set; }
		public string Type { get; set; }
		public AMedia() {
			Title = "Untitled";
			Type = "None";
		}
	}
}