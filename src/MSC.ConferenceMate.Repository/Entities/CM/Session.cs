// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // Session
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class Session
    {
        public int SessionId { get; set; } // SessionId (Primary key)
        public string Title { get; set; } // Title (length: 1000)
        public string ShortTitle { get; set; } // ShortTitle (length: 500)
        public string Description { get; set; } // Description (length: 4000)
        public int? RoomId { get; set; } // RoomId
        public System.DateTime? StartTime { get; set; } // StartTime
        public System.DateTime? EndTime { get; set; } // EndTime
        public int DataVersion { get; set; } // DataVersion
        public System.DateTime CreatedUtcDate { get; set; } // CreatedUtcDate
        public string CreatedBy { get; set; } // CreatedBy (length: 200)
        public System.DateTime ModifiedUtcDate { get; set; } // ModifiedUtcDate
        public string ModifiedBy { get; set; } // ModifiedBy (length: 200)
        public bool IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child Feedbacks where [Feedback].[SessionId] point to this entity (FK_Feedback_Session)
        /// </summary>
        public System.Collections.Generic.ICollection<Feedback> Feedbacks { get; set; } // Feedback.FK_Feedback_Session
        /// <summary>
        /// Child SessionLikes where [Session_Like].[SessionId] point to this entity (FK_Session_Like_Session)
        /// </summary>
        public System.Collections.Generic.ICollection<SessionLike> SessionLikes { get; set; } // Session_Like.FK_Session_Like_Session
        /// <summary>
        /// Child SessionSessionCategoryTypes where [Session_SessionCategoryType].[SessionId] point to this entity (FK_Session_SessionCategoryType_Session)
        /// </summary>
        public System.Collections.Generic.ICollection<SessionSessionCategoryType> SessionSessionCategoryTypes { get; set; } // Session_SessionCategoryType.FK_Session_SessionCategoryType_Session
        /// <summary>
        /// Child SessionSpeakers where [Session_Speaker].[SessionId] point to this entity (FK_Session_Speaker_Session)
        /// </summary>
        public System.Collections.Generic.ICollection<SessionSpeaker> SessionSpeakers { get; set; } // Session_Speaker.FK_Session_Speaker_Session

        // Foreign keys

        /// <summary>
        /// Parent Room pointed by [Session].([RoomId]) (FK_Session_Room)
        /// </summary>
        public Room Room { get; set; } // FK_Session_Room

        public Session()
        {
            DataVersion = 1;
            CreatedUtcDate = System.DateTime.UtcNow;
            ModifiedUtcDate = System.DateTime.UtcNow;
            IsDeleted = false;
            Feedbacks = new System.Collections.Generic.List<Feedback>();
            SessionLikes = new System.Collections.Generic.List<SessionLike>();
            SessionSessionCategoryTypes = new System.Collections.Generic.List<SessionSessionCategoryType>();
            SessionSpeakers = new System.Collections.Generic.List<SessionSpeaker>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
