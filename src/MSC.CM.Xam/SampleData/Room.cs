// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;

namespace MSC.CM.Xam.ModelData.CM
{
	public static class DemoRoom
	{
		public static int SampleRoomId0000 = 179454933;
		public static int SampleRoomId0100 = 1158400312;

		public static Room SampleRoom00
		{
			get
			{
				return new Room()
				{
					RoomId = SampleRoomId0000,
					Title = "SampleTitle",
					ShortTitle = "SampleShortTitle",
					Description = "SampleDescription",
					SeatingCapacity = 0,
					Latitude = 0,
					Longitude = 0,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}
		public static Room SampleRoom01
		{
			get
			{
				return new Room()
				{
					RoomId = SampleRoomId0100,
					Title = "SampleTitle",
					ShortTitle = "SampleShortTitle",
					Description = "SampleDescription",
					SeatingCapacity = 0,
					Latitude = 0,
					Longitude = 0,
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
