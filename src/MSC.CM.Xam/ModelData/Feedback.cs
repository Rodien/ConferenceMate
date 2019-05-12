// <auto-generated> - Template:SqliteModelData, Version:1.1, Id:c5caad15-b3be-4443-87d8-7cabde59f7b0
using SQLite;

namespace MSC.CM.Xam.ModelData.CM
{
	[Table("Feedback")]
	public partial class Feedback
	{
		public string CreatedBy { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public int DataVersion { get; set; }
		public string Description { get; set; }
		public bool Dispositioned { get; set; }
		public int? FeaturedEventId { get; set; }

		[PrimaryKey]
		public System.Guid FeedbackId { get; set; }

		public int FeedbackInitiatorTypeId { get; set; }
		public int FeedbackTypeId { get; set; }
		public bool? IsChat { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsPublic { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public string ModifiedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
		public string RatingValue { get; set; }
		public int? SessionId { get; set; }
		public string Source { get; set; }
		public string Title { get; set; }
		public int? UserId { get; set; }
	}
}
