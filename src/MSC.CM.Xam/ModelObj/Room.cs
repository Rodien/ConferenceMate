// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;

namespace MSC.CM.Xam.ModelObj.CM
{
	public partial class Room : ObservableObject
	{
		public Room()
		{
			Sessions = new System.Collections.Generic.List<Session>(); // Reverse Navigation

			InitializePartial();
		}

		private string _createdBy;
		private System.DateTime _createdUtcDate;
		private int _dataVersion;
		private string _description;
		private bool _isDeleted;
		private double _latitude;
		private double _longitude;
		private string _modifiedBy;
		private System.DateTime _modifiedUtcDate;
		private int _roomId;
		private int _seatingCapacity;
		private string _shortTitle;
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

		public bool IsDeleted
		{
			get { return _isDeleted; }
			set
			{
				Set<bool>(() => IsDeleted, ref _isDeleted, value);
				RunCustomLogicSetIsDeleted(value);
			}
		}

		public double Latitude
		{
			get { return _latitude; }
			set
			{
				Set<double>(() => Latitude, ref _latitude, value);
				RunCustomLogicSetLatitude(value);
			}
		}

		public double Longitude
		{
			get { return _longitude; }
			set
			{
				Set<double>(() => Longitude, ref _longitude, value);
				RunCustomLogicSetLongitude(value);
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

		public int RoomId
		{
			get { return _roomId; }
			set
			{
				Set<int>(() => RoomId, ref _roomId, value);
				RunCustomLogicSetRoomId(value);
			}
		}

		public int SeatingCapacity
		{
			get { return _seatingCapacity; }
			set
			{
				Set<int>(() => SeatingCapacity, ref _seatingCapacity, value);
				RunCustomLogicSetSeatingCapacity(value);
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

		public string Title
		{
			get { return _title; }
			set
			{
				Set<string>(() => Title, ref _title, value);
				RunCustomLogicSetTitle(value);
			}
		}

		public virtual System.Collections.Generic.IList<Session> Sessions { get; set; } // Many to many mapping


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetCreatedBy(string value);
		partial void RunCustomLogicSetCreatedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetDataVersion(int value);
		partial void RunCustomLogicSetDescription(string value);
		partial void RunCustomLogicSetIsDeleted(bool value);
		partial void RunCustomLogicSetLatitude(double value);
		partial void RunCustomLogicSetLongitude(double value);
		partial void RunCustomLogicSetModifiedBy(string value);
		partial void RunCustomLogicSetModifiedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetRoomId(int value);
		partial void RunCustomLogicSetSeatingCapacity(int value);
		partial void RunCustomLogicSetShortTitle(string value);
		partial void RunCustomLogicSetTitle(string value);

		#endregion RunCustomLogicSet

	}
}
