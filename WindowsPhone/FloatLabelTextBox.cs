using System.ComponentModel;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace XamlFloatLabel {

	public class FloatLabelTextBox : TextBox {

		public FloatLabelTextBox() {
			DefaultStyleKey = typeof(FloatLabelTextBox);
			SetCaretToAccentColor();
			TextChanged += OnTextChanged;
			Loaded += OnLoaded;
		}

		public static readonly DependencyProperty LabelProperty =
			DependencyProperty.Register("Label", typeof(string), typeof(FloatLabelTextBox), new PropertyMetadata(""));

		[Category("Common")]
		public string Label {
			get { return (string)GetValue(LabelProperty); }
			set { SetValue(LabelProperty, value); }
		}

		public void OnLoaded(object sender, RoutedEventArgs e) {
			UpdateTextVisualState(false);
		}

		public override void OnApplyTemplate() {
			base.OnApplyTemplate();
			UpdateTextVisualState(false);
		}

		private void OnTextChanged(object sender, TextChangedEventArgs args) {
			UpdateTextVisualState();
		}

		private void UpdateTextVisualState(bool isAnimated = true) {
			if (string.IsNullOrEmpty(Text))
				VisualStateManager.GoToState(this, "WithoutText", isAnimated);
			else
				VisualStateManager.GoToState(this, "WithText", isAnimated);
		}

		private void SetCaretToAccentColor() {
			var brush = (SolidColorBrush)Application.Current.Resources["PhoneAccentBrush"];
			CaretBrush = new SolidColorBrush(brush.Color);
		}
	}
}
