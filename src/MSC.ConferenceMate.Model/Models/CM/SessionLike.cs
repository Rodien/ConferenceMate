// <auto-generated> - Template:ModelsBackedByDto, Version:1.1, Id:f1539c0d-024f-4b1f-b346-132cdd9dd31f
using CodeGenHero.Logging;
using CodeGenHero.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using MSC.ConferenceMate.API.Client.Interface;
using MSC.ConferenceMate.Model.CM.Interface;
using xDTO = MSC.ConferenceMate.DTO.CM;

namespace MSC.ConferenceMate.Model.CM
{

	public class LoadRequestSessionLike : EventArgs
	{
		public LoadRequestSessionLike(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class SessionLike : BaseModel<IWebApiDataServiceCM>, ISessionLike
	{
		public event EventHandler<LoadRequestSessionLike> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.SessionLike _dto = null;

		public SessionLike(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService) : base(log, dataService)
		{
			_dto = new xDTO.SessionLike();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public SessionLike(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService, xDTO.SessionLike dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string CreatedBy { get { return _dto.CreatedBy; } }
		public virtual System.DateTime CreatedUtcDate { get { return _dto.CreatedUtcDate; } }
		public virtual int DataVersion { get { return _dto.DataVersion; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual string ModifiedBy { get { return _dto.ModifiedBy; } }
		public virtual System.DateTime ModifiedUtcDate { get { return _dto.ModifiedUtcDate; } }
		public virtual int SessionId { get { return _dto.SessionId; } }
		public virtual int UserProfileId { get { return _dto.UserProfileId; } }

		// Excluding 'Session' per configuration setting.
		private IUserProfile _userProfile = null; // Foreign Key


		public virtual IUserProfile UserProfile
		{
			get
			{
				if (_userProfile == null && _dto != null && _dto.UserProfile != null)
				{
					_userProfile = new UserProfile(Log, DataService, _dto.UserProfile);
				}

				return _userProfile;
			}
		}



	}
}
