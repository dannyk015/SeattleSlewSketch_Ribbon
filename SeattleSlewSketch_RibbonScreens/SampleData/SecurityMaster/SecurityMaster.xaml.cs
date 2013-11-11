﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SecurityMaster
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class Report { }
#else

	public class Report : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public Report()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/SeattleSlewSketch_Ribbon.Screens;component/SampleData/SecurityMaster/SecurityMaster.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private rowCollection _Data = new rowCollection();

		public rowCollection Data
		{
			get
			{
				return this._Data;
			}
		}
	}

	public class row : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _SecTypeCode = string.Empty;

		public string SecTypeCode
		{
			get
			{
				return this._SecTypeCode;
			}

			set
			{
				if (this._SecTypeCode != value)
				{
					this._SecTypeCode = value;
					this.OnPropertyChanged("SecTypeCode");
				}
			}
		}

		private string _SecTypeNameLong = string.Empty;

		public string SecTypeNameLong
		{
			get
			{
				return this._SecTypeNameLong;
			}

			set
			{
				if (this._SecTypeNameLong != value)
				{
					this._SecTypeNameLong = value;
					this.OnPropertyChanged("SecTypeNameLong");
				}
			}
		}

		private string _Symbol = string.Empty;

		public string Symbol
		{
			get
			{
				return this._Symbol;
			}

			set
			{
				if (this._Symbol != value)
				{
					this._Symbol = value;
					this.OnPropertyChanged("Symbol");
				}
			}
		}

		private string _CUSIP = string.Empty;

		public string CUSIP
		{
			get
			{
				return this._CUSIP;
			}

			set
			{
				if (this._CUSIP != value)
				{
					this._CUSIP = value;
					this.OnPropertyChanged("CUSIP");
				}
			}
		}

		private string _FullName = string.Empty;

		public string FullName
		{
			get
			{
				return this._FullName;
			}

			set
			{
				if (this._FullName != value)
				{
					this._FullName = value;
					this.OnPropertyChanged("FullName");
				}
			}
		}

		private double _UserDef1 = 0;

		public double UserDef1
		{
			get
			{
				return this._UserDef1;
			}

			set
			{
				if (this._UserDef1 != value)
				{
					this._UserDef1 = value;
					this.OnPropertyChanged("UserDef1");
				}
			}
		}

		private string _AssetClass = string.Empty;

		public string AssetClass
		{
			get
			{
				return this._AssetClass;
			}

			set
			{
				if (this._AssetClass != value)
				{
					this._AssetClass = value;
					this.OnPropertyChanged("AssetClass");
				}
			}
		}

		private double _UserDef2 = 0;

		public double UserDef2
		{
			get
			{
				return this._UserDef2;
			}

			set
			{
				if (this._UserDef2 != value)
				{
					this._UserDef2 = value;
					this.OnPropertyChanged("UserDef2");
				}
			}
		}

		private double _UserDef3 = 0;

		public double UserDef3
		{
			get
			{
				return this._UserDef3;
			}

			set
			{
				if (this._UserDef3 != value)
				{
					this._UserDef3 = value;
					this.OnPropertyChanged("UserDef3");
				}
			}
		}
	}

	public class rowCollection : System.Collections.ObjectModel.ObservableCollection<row>
	{ 
	}
#endif
}
