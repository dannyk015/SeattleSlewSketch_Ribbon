﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.ScriptsSampleDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class ScriptMenu { }
#else

	public class ScriptMenu : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public ScriptMenu()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/SeattleSlewSketch_Ribbon.Screens;component/SampleData/ScriptsSampleDataSource/ScriptsSampleDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private RowCollection _RowCollection = new RowCollection();

		public RowCollection RowCollection
		{
			get
			{
				return this._RowCollection;
			}
		}
	}

	public class Row : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _MenuItemEntry = string.Empty;

		public string MenuItemEntry
		{
			get
			{
				return this._MenuItemEntry;
			}

			set
			{
				if (this._MenuItemEntry != value)
				{
					this._MenuItemEntry = value;
					this.OnPropertyChanged("MenuItemEntry");
				}
			}
		}

		private string _ScriptFile = string.Empty;

		public string ScriptFile
		{
			get
			{
				return this._ScriptFile;
			}

			set
			{
				if (this._ScriptFile != value)
				{
					this._ScriptFile = value;
					this.OnPropertyChanged("ScriptFile");
				}
			}
		}

		private string _Arguments = string.Empty;

		public string Arguments
		{
			get
			{
				return this._Arguments;
			}

			set
			{
				if (this._Arguments != value)
				{
					this._Arguments = value;
					this.OnPropertyChanged("Arguments");
				}
			}
		}
	}

	public class RowCollection : System.Collections.ObjectModel.ObservableCollection<Row>
	{ 
	}
#endif
}
