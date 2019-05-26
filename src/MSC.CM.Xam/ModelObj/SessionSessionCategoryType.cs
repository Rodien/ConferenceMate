// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;

namespace MSC.CM.Xam.ModelObj.CM
{
	public partial class SessionSessionCategoryType : ObservableObject
	{
		public SessionSessionCategoryType()
		{
			InitializePartial();
		}

		private string _createdBy;
		private System.DateTime _createdUtcDate;
		private int _dataVersion;
		private bool _isDeleted;
		private string _modifiedBy;
		private System.DateTime _modifiedUtcDate;
		private int _sessionCategoryTypeId;
		private int _sessionId;


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

		public bool IsDeleted
		{
			get { return _isDeleted; }
			set
			{
				Set<bool>(() => IsDeleted, ref _isDeleted, value);
				RunCustomLogicSetIsDeleted(value);
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

		public int SessionCategoryTypeId
		{
			get { return _sessionCategoryTypeId; }
			set
			{
				Set<int>(() => SessionCategoryTypeId, ref _sessionCategoryTypeId, value);
				RunCustomLogicSetSessionCategoryTypeId(value);
			}
		}

		public int SessionId
		{
			get { return _sessionId; }
			set
			{
				Set<int>(() => SessionId, ref _sessionId, value);
				RunCustomLogicSetSessionId(value);
			}
		}

		public virtual Session Session { get; set; } 
		public virtual SessionCategoryType SessionCategoryType { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetCreatedBy(string value);
		partial void RunCustomLogicSetCreatedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetDataVersion(int value);
		partial void RunCustomLogicSetIsDeleted(bool value);
		partial void RunCustomLogicSetModifiedBy(string value);
		partial void RunCustomLogicSetModifiedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetSessionCategoryTypeId(int value);
		partial void RunCustomLogicSetSessionId(int value);

		#endregion RunCustomLogicSet

	}
}