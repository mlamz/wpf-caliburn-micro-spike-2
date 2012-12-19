using System;
using Caliburn.Micro;

namespace CaliburnMicroSpike2
{
	public class ToDoListItem: PropertyChangedBase
	{
		private string _color = "Green";
		
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
	}
}