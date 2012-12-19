using System;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Input;
using Caliburn.Micro;

namespace CaliburnMicroSpike2
{
	[Export(typeof(AppViewModel))]
	public class AppViewModel: PropertyChangedBase
	{
		public BindableCollection<ToDoListItem> ToDoListItems { get; private set; }

		public AppViewModel()
		{
			ToDoListItems = new BindableCollection<ToDoListItem>
			{
				new ToDoListItem { Id = Guid.NewGuid(), Text = "Item 1" },
				new ToDoListItem { Id = Guid.NewGuid(), Text = "Item 2" },
				new ToDoListItem { Id = Guid.NewGuid(), Text = "Item 3" },
				new ToDoListItem { Id = Guid.NewGuid(), Text = "Item 4" },
			};
		}

		public void Add()
		{
			ToDoListItems.Add(new ToDoListItem { Id = Guid.NewGuid(), Text = "New Item" });
		}

		public void Remove(ToDoListItem child)
		{
			ToDoListItems.Remove(child);
		}



		public void OpenItem(ToDoListItem item)
		{
			item.Color = "Red";
		}

	}
}