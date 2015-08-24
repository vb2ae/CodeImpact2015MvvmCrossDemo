using System;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MvvmCross.Core.ViewModels
{
	public class ListViewModel: MvxViewModel
	{

		    public ObservableCollection<Person> List { get; set; }


			public ListViewModel()
				{
					List = new ObservableCollection<Person>();
				List.Add(new Person() {Name="Ken Tucker"});		
			List.Add(new Person() {Name="Bob Smith"});
				List.Add(new Person() {Name="John Doe"});
				}
			
			public class Person
			{
				public string Name { get; set; }
			}
	}
}

