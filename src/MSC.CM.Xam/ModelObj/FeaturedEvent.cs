// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;

namespace MSC.CM.Xam.ModelObj.CM
{
	public partial class FeaturedEvent : ObservableObject
	{
		public FeaturedEvent()
		{
			Feedbacks = new System.Collections.Generic.List<Feedback>(); // Reverse Navigation
			SponsorFeaturedEvents = new System.Collections.Generic.List<SponsorFeaturedEvent>(); // Reverse Navigation

			InitializePartial();
		}

		private string _createdBy;
		private System.DateTime _createdUtcDate;
		private int _dataVersion;
		private string _description;
		private System.DateTime? _endTime;
		private int _featuredEventId;
		private bool _isAllDay;
		private bool _isDeleted;
		private string _location;
		private string _modifiedBy;
		private System.DateTime _modifiedUtcDate;
		private string _shortTitle;
		private System.DateTime? _startTime;
		private string _title;


		public string CreatedBy
		{
			get { return _createdBy; }
			set
			{
				Set<string>(() => CreatedBy, ref _createdBy, value);
				RunCustomLogicSetCreatedBy(value);
			}
		}

		public System.DateTime CreatedUtcDate
		{
			get { return _createdUtcDate; }
			set
			{
				Set<System.DateTime>(() => CreatedUtcDate, ref _createdUtcDate, value);
				RunCustomLogicSetCreatedUtcDate(value);
			}
		}

		public int DataVersion
		{
			get { return _dataVersion; }
			set
			{
				Set<int>(() => DataVersion, ref _dataVersion, value);
				RunCustomLogicSetDataVersion(value);
			}
		}

		public string Description
		{
			get { return _description; }
			set
			{
				Set<string>(() => Description, ref _description, value);
				RunCustomLogicSetDescription(value);
			}
		}

		public System.DateTime? EndTime
		{
			get { return _endTime; }
			set
			{
				Set<System.DateTime?>(() => EndTime, ref _endTime, value);
				RunCustomLogicSetEndTime(value);
			}
		}

		public int FeaturedEventId
		{
			get { return _featuredEventId; }
			set
			{
				Set<int>(() => FeaturedEventId, ref _featuredEventId, value);
				RunCustomLogicSetFeaturedEventId(value);
			}
		}

		public bool IsAllDay
		{
			get { return _isAllDay; }
			set
			{
				Set<bool>(() => IsAllDay, ref _isAllDay, value);
				RunCustomLogicSetIsAllDay(value);
			}
		}

		public bool IsDeleted
		{
			get { return _isDeleted; }
			set
			{
				Set<bool>(() => IsDeleted, ref _isDeleted, value);
				RunCustomLogicSetIsDeleted(value);
			}
		}

		public string Location
		{
			get { return _location; }
			set
			{
				Set<string>(() => Location, ref _location, value);
				RunCustomLogicSetLocation(value);
			}
		}

		public string ModifiedBy
		{
			get { return _modifiedBy; }
			set
			{
				Set<string>(() => ModifiedBy, ref _modifiedBy, value);
				RunCustomLogicSetModifiedBy(value);
			}
		}

		public System.DateTime ModifiedUtcDate
		{
			get { return _modifiedUtcDate; }
			set
			{
				Set<System.DateTime>(() => ModifiedUtcDate, ref _modifiedUtcDate, value);
				RunCustomLogicSetModifiedUtcDate(value);
			}
		}

		public string ShortTitle
		{
			get { return _shortTitle; }
			set
			{
				Set<string>(() => ShortTitle, ref _shortTitle, value);
				RunCustomLogicSetShortTitle(value);
			}
		}

		public System.DateTime? StartTime
		{
			get { return _startTime; }
			set
			{
				Set<System.DateTime?>(() => StartTime, ref _startTime, value);
				RunCustomLogicSetStartTime(value);
			}
		}

		public string Title
		{
			get { return _title; }
			set
			{
				Set<string>(() => Title, ref _title, value);
				RunCustomLogicSetTitle(value);
			}
		}

		public virtual System.Collections.Generic.IList<Feedback> Feedbacks { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<SponsorFeaturedEvent> SponsorFeaturedEvents { get; set; } // Many to many mapping


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetCreatedBy(string value);
		partial void RunCustomLogicSetCreatedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetDataVersion(int value);
		partial void RunCustomLogicSetDescription(string value);
		partial void RunCustomLogicSetEndTime(System.DateTime? value);
		partial void RunCustomLogicSetFeaturedEventId(int value);
		partial void RunCustomLogicSetIsAllDay(bool value);
		partial void RunCustomLogicSetIsDeleted(bool value);
		partial void RunCustomLogicSetLocation(string value);
		partial void RunCustomLogicSetModifiedBy(string value);
		partial void RunCustomLogicSetModifiedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetShortTitle(string value);
		partial void RunCustomLogicSetStartTime(System.DateTime? value);
		partial void RunCustomLogicSetTitle(string value);

		#endregion RunCustomLogicSet

	}
}
