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
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // BlobFileType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class BlobFileType
    {
        public int BlobFileTypeId { get; set; } // BlobFileTypeId (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public string GeneralType { get; set; } // GeneralType (length: 50)
        public string CategoryType { get; set; } // CategoryType (length: 50)
        public int? ResolutionX { get; set; } // ResolutionX
        public int? ResolutionY { get; set; } // ResolutionY
        public int? ResizeFromBlobFileTypeId { get; set; } // ResizeFromBlobFileTypeId
        public int DataVersion { get; set; } // DataVersion
        public System.DateTime CreatedUtcDate { get; set; } // CreatedUtcDate
        public string CreatedBy { get; set; } // CreatedBy (length: 200)
        public System.DateTime ModifiedUtcDate { get; set; } // ModifiedUtcDate
        public string ModifiedBy { get; set; } // ModifiedBy (length: 200)
        public bool IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child BlobFiles where [BlobFile].[BlobFileTypeId] point to this entity (FK_BlobFileType)
        /// </summary>
        public System.Collections.Generic.ICollection<BlobFile> BlobFiles { get; set; } // BlobFile.FK_BlobFileType
        /// <summary>
        /// Child BlobFileTypes where [BlobFileType].[ResizeFromBlobFileTypeId] point to this entity (FK_BlobFileType_BlobFileType)
        /// </summary>
        public System.Collections.Generic.ICollection<BlobFileType> BlobFileTypes { get; set; } // BlobFileType.FK_BlobFileType_BlobFileType

        // Foreign keys

        /// <summary>
        /// Parent BlobFileType pointed by [BlobFileType].([ResizeFromBlobFileTypeId]) (FK_BlobFileType_BlobFileType)
        /// </summary>
        public BlobFileType ResizeFromBlobFileType { get; set; } // FK_BlobFileType_BlobFileType

        public BlobFileType()
        {
            DataVersion = 1;
            CreatedUtcDate = System.DateTime.UtcNow;
            ModifiedUtcDate = System.DateTime.UtcNow;
            IsDeleted = false;
            BlobFiles = new System.Collections.Generic.List<BlobFile>();
            BlobFileTypes = new System.Collections.Generic.List<BlobFileType>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
