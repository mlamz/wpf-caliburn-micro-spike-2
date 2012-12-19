using System;
using Caliburn.Micro;

namespace CaliburnMicroSpike2
{
	public class ToDoListItem: PropertyChangedBase
	{
		private string _color = FormConstants.ListItemBackgroundColorInactive;
		private bool _readonly = true;
		
		public Guid	Id { get; set; }
		public string Text { get; set; }
		
		public string Color 
		{ 
			get { return _color;  } 
			set 
			{ 
				_color = value;
				NotifyOfPropertyChange(() => Color); 
			} 
		}

		public bool Readonly
		{
			get { return _readonly; }
			set
			{
				_readonly = value;
				NotifyOfPropertyChange(() => Readonly);
			}
		}
	}
}