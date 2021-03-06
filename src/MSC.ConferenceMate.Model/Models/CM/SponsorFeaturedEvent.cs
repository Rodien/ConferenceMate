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

	public class LoadRequestSponsorFeaturedEvent : EventArgs
	{
		public LoadRequestSponsorFeaturedEvent(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class SponsorFeaturedEvent : BaseModel<IWebApiDataServiceCM>, ISponsorFeaturedEvent
	{
		public event EventHandler<LoadRequestSponsorFeaturedEvent> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.SponsorFeaturedEvent _dto = null;

		public SponsorFeaturedEvent(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService) : base(log, dataService)
		{
			_dto = new xDTO.SponsorFeaturedEvent();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public SponsorFeaturedEvent(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService, xDTO.SponsorFeaturedEvent dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string CreatedBy { get { return _dto.CreatedBy; } }
		public virtual System.DateTime CreatedUtcDate { get { return _dto.CreatedUtcDate; } }
		public virtual int DataVersion { get { return _dto.DataVersion; } }
		public virtual int FeaturedEventId { get { return _dto.FeaturedEventId; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual string ModifiedBy { get { return _dto.ModifiedBy; } }
		public virtual System.DateTime ModifiedUtcDate { get { return _dto.ModifiedUtcDate; } }
		public virtual int SponsorId { get { return _dto.SponsorId; } }

		// Excluding 'FeaturedEvent' per configuration setting.
		// Excluding 'Sponsor' per configuration setting.




	}
}
