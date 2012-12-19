using System;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace CaliburnMicroSpike2
{
	[Export(typeof(AppViewModel))]
	public class AppViewModel: PropertyChangedBase
	{
		private int _itemCounter = 4;
		
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
			_itemCounter = _itemCounter + 1;
			ToDoListItems.Add(new ToDoListItem { Id = Guid.NewGuid(), Text = string.Format("Item {0}", _itemCounter) });
		}

		public void Remove(ToDoListItem child)
		{
			ToDoListItems.Remove(child);
		}

		public void OpenItem(ToDoListItem item)
		{
			item.Color = FormConstants.ListItemBackgroundColorActive;
			item.Readonly = false;
		}

		public void CloseItem(ToDoListItem item)
		{
			item.Color = FormConstants.ListItemBackgroundColorInactive;
			item.Readonly = true;
		}
	}
}