using Cirrious.MvvmCross.ViewModels;
using System;
using System.Windows.Input;

namespace MvvmCross.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {

		public FirstViewModel()
		{
			//SetTime= new MvxCommand(()=>{SetTimeString();});
			SetTime= new MvxCommand(()=>{GotoList();});
		}

		public ICommand SetTime { get; private set; }

		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

		private string _getTime = "Time";
		public string GetTime
		{ 
			get { return _getTime; }
			set { _getTime = value; RaisePropertyChanged(() => GetTime); }
		}

		public void SetTimeString()
		{
			GetTime = DateTime.Now.ToString ();
		}

		public void GotoList()
		{
			ShowViewModel<ListViewModel> ();
		}
    }
}
