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

	public class LoadRequestSponsor : EventArgs
	{
		public LoadRequestSponsor(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class Sponsor : BaseModel<IWebApiDataServiceCM>, ISponsor
	{
		public event EventHandler<LoadRequestSponsor> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.Sponsor _dto = null;

		public Sponsor(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService) : base(log, dataService)
		{
			_dto = new xDTO.Sponsor();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public Sponsor(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService, xDTO.Sponsor dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string BoothLocation { get { return _dto.BoothLocation; } }
		public virtual string CreatedBy { get { return _dto.CreatedBy; } }
		public virtual System.DateTime CreatedUtcDate { get { return _dto.CreatedUtcDate; } }
		public virtual int DataVersion { get { return _dto.DataVersion; } }
		public virtual string Description { get { return _dto.Description; } }
		public virtual string ImageUrl { get { return _dto.ImageUrl; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual string ModifiedBy { get { return _dto.ModifiedBy; } }
		public virtual System.DateTime ModifiedUtcDate { get { return _dto.ModifiedUtcDate; } }
		public virtual int Rank { get { return _dto.Rank; } }
		public virtual string ShortTitle { get { return _dto.ShortTitle; } }
		public virtual int SponsorId { get { return _dto.SponsorId; } }
		public virtual int SponsorTypeId { get { return _dto.SponsorTypeId; } }
		public virtual string Title { get { return _dto.Title; } }
		public virtual string TwitterUrl { get { return _dto.TwitterUrl; } }
		public virtual string WebsiteUrl { get { return _dto.WebsiteUrl; } }

		private ISponsorType _sponsorType = null; // Foreign Key
		private List<ISponsorFeaturedEvent> _sponsorFeaturedEvents = null; // Reverse Navigation


		public virtual ISponsorType SponsorType
		{
			get
			{
				if (_sponsorType == null && _dto != null && _dto.SponsorType != null)
				{
					_sponsorType = new SponsorType(Log, DataService, _dto.SponsorType);
				}

				return _sponsorType;
			}
		}

		public virtual List<ISponsorFeaturedEvent> SponsorFeaturedEvents
		{
			get
			{
				if (_sponsorFeaturedEvents == null && _dto != null)
				{	// The core DTO object is loaded, but this property is not loaded.
					if (_dto.SponsorFeaturedEvents != null)
					{	// The core DTO object has data for this property, load it into the model.
						_sponsorFeaturedEvents = new List<ISponsorFeaturedEvent>();
						foreach (var dtoItem in _dto.SponsorFeaturedEvents)
						{
							_sponsorFeaturedEvents.Add(new SponsorFeaturedEvent(Log, DataService, dtoItem));
						}
					}
					else
					{	// Trigger the load data request - The core DTO object is loaded and does not have data for this property.
						OnLazyLoadRequest(this, new LoadRequestSponsor(nameof(SponsorFeaturedEvents)));
					}
				}

				return _sponsorFeaturedEvents;
			}
		}



	}
}
