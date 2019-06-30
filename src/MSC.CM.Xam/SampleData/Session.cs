// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;

namespace MSC.CM.Xam.ModelData.CM
{
	public static class DemoSession
	{
		public static int SampleSessionId0000 = 1851998887;
		public static int SampleSessionId0100 = 1372120977;

		public static Session SampleSession00
		{
			get
			{
				return new Session()
				{
					SessionId = SampleSessionId0000,
					Title = "SampleTitle",
					ShortTitle = "SampleShortTitle",
					Description = "SampleDescription",
					RoomId = DemoRoom.SampleRoomId0000,
					StartTime = DateTime.Now,
					EndTime = DateTime.Now,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}
		public static Session SampleSession01
		{
			get
			{
				return new Session()
				{
					SessionId = SampleSessionId0100,
					Title = "SampleTitle",
					ShortTitle = "SampleShortTitle",
					Description = "SampleDescription",
					RoomId = DemoRoom.SampleRoomId0100,
                    StartTime = DateTime.Now,
					EndTime = DateTime.Now,
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
