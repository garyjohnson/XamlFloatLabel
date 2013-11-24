using XamlFloatLabel.WindowsPhoneSample.Resources;

namespace XamlFloatLabel.WindowsPhoneSample {
	/// <summary>
	/// Provides access to string resources.
	/// </summary>
	public class LocalizedStrings {
		private static AppResources _localizedResources = new AppResources();

		public AppResources LocalizedResources { get { return _localizedResources; } }
	}
}