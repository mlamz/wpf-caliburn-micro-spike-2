using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Input;
using Caliburn.Micro;

namespace CaliburnMicroSpike2
{
	[Export(typeof(AppViewModel))]
	public class AppViewModel: PropertyChangedBase
	{
		private string _textBox1 = "item 1";
		private bool _textBoxReadOnly = true;
		private string _textBox1Background = "#666666";

		public string TextBox1
		{
			get { return _textBox1; }
			set
			{
				_textBox1 = value;
				NotifyOfPropertyChange(() => TextBox1);
			}
		}
		
		public void OpenItem(object sender, object eventArgs)
		{
			TextBox1ReadOnly = false;
			TextBox1Background = "#999999";
			TextBox1 += ".";
		}

		public bool TextBox1ReadOnly
		{
			get { return _textBoxReadOnly; }
			set
			{
				_textBoxReadOnly = value;
				NotifyOfPropertyChange(() => TextBox1ReadOnly);
			}
		}

		public string TextBox1Background
		{
			get { return _textBox1Background; }
			set
			{
				_textBox1Background = value;
				NotifyOfPropertyChange(() => TextBox1Background);
			}
		}

		public void KeyDown(KeyEventArgs eventArgs)
		{
			if (eventArgs.Key == Key.Return)
			{
				TextBox1ReadOnly = true;
				TextBox1Background = "#666666";
			}
		}
	}
}