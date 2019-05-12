// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;

namespace MSC.CM.Xam.ModelData.CM
{
	public static class DemoSessionLike
	{
		public static int SampleSessionLikeId0000 = DemoSession.SampleSessionId0000;
		public static int SampleSessionLikeId0001 = DemoUser.SampleUserId0000;
		public static int SampleSessionLikeId0100 = DemoSession.SampleSessionId0100;
		public static int SampleSessionLikeId0101 = DemoUser.SampleUserId0100;

		public static SessionLike SampleSessionLike00
		{
			get
			{
				return new SessionLike()
				{
					SessionId = SampleSessionLikeId0000,
					UserId = SampleSessionLikeId0001,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}
		public static SessionLike SampleSessionLike01
		{
			get
			{
				return new SessionLike()
				{
					SessionId = SampleSessionLikeId0100,
					UserId = SampleSessionLikeId0101,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}

	}
}
