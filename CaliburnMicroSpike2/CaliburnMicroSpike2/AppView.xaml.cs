using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CaliburnMicroSpike2
{
	/// <summary>
	/// Interaction logic for AppView.xaml
	/// </summary>
	public partial class AppView : UserControl
	{
		public AppView()
		{
			InitializeComponent();
		}

		private void textBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			var textBox = sender as TextBox;
			SetTextBoxEdit(textBox);
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			var key = e.Key;
			if (key == Key.Return)
			{
				SetTextBoxReadonly((TextBox)sender);
			}
		}

		private void SetTextBoxReadonly(TextBox textBox)
		{
			textBox.IsReadOnly = true;
			var backgroundColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
			textBox.Background = backgroundColor;
			textBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#AAAAAA"));
			textBox.CaretBrush = backgroundColor;
		}

		private void SetTextBoxEdit(TextBox textBox)
		{
			textBox.IsReadOnly = false;
			textBox.Background = new SolidColorBrush(Colors.DarkSlateGray);
			textBox.Foreground = new SolidColorBrush(Colors.White);
			textBox.CaretBrush = new SolidColorBrush(Colors.White);
			textBox.Focus();
		}
	}
}
