#if WINPHONE
using System.Windows;
using System.Windows.Controls;
#elif WINRT
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#endif

namespace XamlFloatLabel {

	public class FloatLabelTextBox : TextBox {

		public FloatLabelTextBox() {
			DefaultStyleKey = typeof(FloatLabelTextBox);
		}

		public static readonly DependencyProperty LabelProperty =
			DependencyProperty.Register("Label", typeof (string), typeof (FloatLabelTextBox), new PropertyMetadata(""));
	}
}
