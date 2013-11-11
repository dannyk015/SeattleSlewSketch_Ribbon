﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SecurityType
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class Record { }
#else

	public class Record : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public Record()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/SeattleSlewSketch_Ribbon.Screens;component/SampleData/SecurityType/SecurityType.xaml", System.UriKind.Relative);
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

	public class rowCollection : System.Collections.ObjectModel.ObservableCollection<row>
	{ 
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

		private string _Type = string.Empty;

		public string Type
		{
			get
			{
				return this._Type;
			}

			set
			{
				if (this._Type != value)
				{
					this._Type = value;
					this.OnPropertyChanged("Type");
				}
			}
		}

		private string _Description = string.Empty;

		public string Description
		{
			get
			{
				return this._Description;
			}

			set
			{
				if (this._Description != value)
				{
					this._Description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}

		private string _IncomeTypeCode = string.Empty;

		public string IncomeTypeCode
		{
			get
			{
				return this._IncomeTypeCode;
			}

			set
			{
				if (this._IncomeTypeCode != value)
				{
					this._IncomeTypeCode = value;
					this.OnPropertyChanged("IncomeTypeCode");
				}
			}
		}

		private string _IncomeCurrencyCode = string.Empty;

		public string IncomeCurrencyCode
		{
			get
			{
				return this._IncomeCurrencyCode;
			}

			set
			{
				if (this._IncomeCurrencyCode != value)
				{
					this._IncomeCurrencyCode = value;
					this.OnPropertyChanged("IncomeCurrencyCode");
				}
			}
		}

		private bool _CanBeBoughtSold = false;

		public bool CanBeBoughtSold
		{
			get
			{
				return this._CanBeBoughtSold;
			}

			set
			{
				if (this._CanBeBoughtSold != value)
				{
					this._CanBeBoughtSold = value;
					this.OnPropertyChanged("CanBeBoughtSold");
				}
			}
		}

		private bool _CanMature = false;

		public bool CanMature
		{
			get
			{
				return this._CanMature;
			}

			set
			{
				if (this._CanMature != value)
				{
					this._CanMature = value;
					this.OnPropertyChanged("CanMature");
				}
			}
		}

		private bool _CanSplit = false;

		public bool CanSplit
		{
			get
			{
				return this._CanSplit;
			}

			set
			{
				if (this._CanSplit != value)
				{
					this._CanSplit = value;
					this.OnPropertyChanged("CanSplit");
				}
			}
		}

		private double _IsVRS = 0;

		public double IsVRS
		{
			get
			{
				return this._IsVRS;
			}

			set
			{
				if (this._IsVRS != value)
				{
					this._IsVRS = value;
					this.OnPropertyChanged("IsVRS");
				}
			}
		}

		private double _IsFFX = 0;

		public double IsFFX
		{
			get
			{
				return this._IsFFX;
			}

			set
			{
				if (this._IsFFX != value)
				{
					this._IsFFX = value;
					this.OnPropertyChanged("IsFFX");
				}
			}
		}

		private double _SettlementLagDays = 0;

		public double SettlementLagDays
		{
			get
			{
				return this._SettlementLagDays;
			}

			set
			{
				if (this._SettlementLagDays != value)
				{
					this._SettlementLagDays = value;
					this.OnPropertyChanged("SettlementLagDays");
				}
			}
		}

		private string _QuantityCalculationPrec = string.Empty;

		public string QuantityCalculationPrec
		{
			get
			{
				return this._QuantityCalculationPrec;
			}

			set
			{
				if (this._QuantityCalculationPrec != value)
				{
					this._QuantityCalculationPrec = value;
					this.OnPropertyChanged("QuantityCalculationPrec");
				}
			}
		}

		private double _IsLongZeroMV = 0;

		public double IsLongZeroMV
		{
			get
			{
				return this._IsLongZeroMV;
			}

			set
			{
				if (this._IsLongZeroMV != value)
				{
					this._IsLongZeroMV = value;
					this.OnPropertyChanged("IsLongZeroMV");
				}
			}
		}

		private bool _CanReinvestDividend = false;

		public bool CanReinvestDividend
		{
			get
			{
				return this._CanReinvestDividend;
			}

			set
			{
				if (this._CanReinvestDividend != value)
				{
					this._CanReinvestDividend = value;
					this.OnPropertyChanged("CanReinvestDividend");
				}
			}
		}

		private string _UseAvgCost = string.Empty;

		public string UseAvgCost
		{
			get
			{
				return this._UseAvgCost;
			}

			set
			{
				if (this._UseAvgCost != value)
				{
					this._UseAvgCost = value;
					this.OnPropertyChanged("UseAvgCost");
				}
			}
		}

		private double _PaymentFrequencyID = 0;

		public double PaymentFrequencyID
		{
			get
			{
				return this._PaymentFrequencyID;
			}

			set
			{
				if (this._PaymentFrequencyID != value)
				{
					this._PaymentFrequencyID = value;
					this.OnPropertyChanged("PaymentFrequencyID");
				}
			}
		}

		private string _AccrualCalendarCode = string.Empty;

		public string AccrualCalendarCode
		{
			get
			{
				return this._AccrualCalendarCode;
			}

			set
			{
				if (this._AccrualCalendarCode != value)
				{
					this._AccrualCalendarCode = value;
					this.OnPropertyChanged("AccrualCalendarCode");
				}
			}
		}

		private bool _CouponDelayDays = false;

		public bool CouponDelayDays
		{
			get
			{
				return this._CouponDelayDays;
			}

			set
			{
				if (this._CouponDelayDays != value)
				{
					this._CouponDelayDays = value;
					this.OnPropertyChanged("CouponDelayDays");
				}
			}
		}

		private double _PayOnMonthEnd = 0;

		public double PayOnMonthEnd
		{
			get
			{
				return this._PayOnMonthEnd;
			}

			set
			{
				if (this._PayOnMonthEnd != value)
				{
					this._PayOnMonthEnd = value;
					this.OnPropertyChanged("PayOnMonthEnd");
				}
			}
		}

		private double _TradeWithAI = 0;

		public double TradeWithAI
		{
			get
			{
				return this._TradeWithAI;
			}

			set
			{
				if (this._TradeWithAI != value)
				{
					this._TradeWithAI = value;
					this.OnPropertyChanged("TradeWithAI");
				}
			}
		}

		private double _IsZeroCoupon = 0;

		public double IsZeroCoupon
		{
			get
			{
				return this._IsZeroCoupon;
			}

			set
			{
				if (this._IsZeroCoupon != value)
				{
					this._IsZeroCoupon = value;
					this.OnPropertyChanged("IsZeroCoupon");
				}
			}
		}

		private string _AmortizeToCode = string.Empty;

		public string AmortizeToCode
		{
			get
			{
				return this._AmortizeToCode;
			}

			set
			{
				if (this._AmortizeToCode != value)
				{
					this._AmortizeToCode = value;
					this.OnPropertyChanged("AmortizeToCode");
				}
			}
		}

		private string _AmortizationMethodCode = string.Empty;

		public string AmortizationMethodCode
		{
			get
			{
				return this._AmortizationMethodCode;
			}

			set
			{
				if (this._AmortizationMethodCode != value)
				{
					this._AmortizationMethodCode = value;
					this.OnPropertyChanged("AmortizationMethodCode");
				}
			}
		}

		private bool _EnterYieldOnCost = false;

		public bool EnterYieldOnCost
		{
			get
			{
				return this._EnterYieldOnCost;
			}

			set
			{
				if (this._EnterYieldOnCost != value)
				{
					this._EnterYieldOnCost = value;
					this.OnPropertyChanged("EnterYieldOnCost");
				}
			}
		}

		private double _UseSimpleInterestInLastPeriod = 0;

		public double UseSimpleInterestInLastPeriod
		{
			get
			{
				return this._UseSimpleInterestInLastPeriod;
			}

			set
			{
				if (this._UseSimpleInterestInLastPeriod != value)
				{
					this._UseSimpleInterestInLastPeriod = value;
					this.OnPropertyChanged("UseSimpleInterestInLastPeriod");
				}
			}
		}

		private string _LongGainClassificationCode = string.Empty;

		public string LongGainClassificationCode
		{
			get
			{
				return this._LongGainClassificationCode;
			}

			set
			{
				if (this._LongGainClassificationCode != value)
				{
					this._LongGainClassificationCode = value;
					this.OnPropertyChanged("LongGainClassificationCode");
				}
			}
		}

		private double _HoldingPeriod = 0;

		public double HoldingPeriod
		{
			get
			{
				return this._HoldingPeriod;
			}

			set
			{
				if (this._HoldingPeriod != value)
				{
					this._HoldingPeriod = value;
					this.OnPropertyChanged("HoldingPeriod");
				}
			}
		}

		private string _RiskCountryCode = string.Empty;

		public string RiskCountryCode
		{
			get
			{
				return this._RiskCountryCode;
			}

			set
			{
				if (this._RiskCountryCode != value)
				{
					this._RiskCountryCode = value;
					this.OnPropertyChanged("RiskCountryCode");
				}
			}
		}

		private string _LongAssetClassCode = string.Empty;

		public string LongAssetClassCode
		{
			get
			{
				return this._LongAssetClassCode;
			}

			set
			{
				if (this._LongAssetClassCode != value)
				{
					this._LongAssetClassCode = value;
					this.OnPropertyChanged("LongAssetClassCode");
				}
			}
		}

		private double _ShortVar = 0;

		public double ShortVar
		{
			get
			{
				return this._ShortVar;
			}

			set
			{
				if (this._ShortVar != value)
				{
					this._ShortVar = value;
					this.OnPropertyChanged("ShortVar");
				}
			}
		}

		private double _SubjectToFederalTax = 0;

		public double SubjectToFederalTax
		{
			get
			{
				return this._SubjectToFederalTax;
			}

			set
			{
				if (this._SubjectToFederalTax != value)
				{
					this._SubjectToFederalTax = value;
					this.OnPropertyChanged("SubjectToFederalTax");
				}
			}
		}

		private double _SubjectToStateTax = 0;

		public double SubjectToStateTax
		{
			get
			{
				return this._SubjectToStateTax;
			}

			set
			{
				if (this._SubjectToStateTax != value)
				{
					this._SubjectToStateTax = value;
					this.OnPropertyChanged("SubjectToStateTax");
				}
			}
		}

		private double _IsUnsupervised = 0;

		public double IsUnsupervised
		{
			get
			{
				return this._IsUnsupervised;
			}

			set
			{
				if (this._IsUnsupervised != value)
				{
					this._IsUnsupervised = value;
					this.OnPropertyChanged("IsUnsupervised");
				}
			}
		}

		private double _QuantityDisplayPrec = 0;

		public double QuantityDisplayPrec
		{
			get
			{
				return this._QuantityDisplayPrec;
			}

			set
			{
				if (this._QuantityDisplayPrec != value)
				{
					this._QuantityDisplayPrec = value;
					this.OnPropertyChanged("QuantityDisplayPrec");
				}
			}
		}

		private double _ValuationFactor = 0;

		public double ValuationFactor
		{
			get
			{
				return this._ValuationFactor;
			}

			set
			{
				if (this._ValuationFactor != value)
				{
					this._ValuationFactor = value;
					this.OnPropertyChanged("ValuationFactor");
				}
			}
		}

		private double _SecTypeGroupID = 0;

		public double SecTypeGroupID
		{
			get
			{
				return this._SecTypeGroupID;
			}

			set
			{
				if (this._SecTypeGroupID != value)
				{
					this._SecTypeGroupID = value;
					this.OnPropertyChanged("SecTypeGroupID");
				}
			}
		}
	}
#endif
}