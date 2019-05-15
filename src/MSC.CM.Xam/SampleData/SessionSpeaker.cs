// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;

namespace MSC.CM.Xam.ModelData.CM
{
	public static class DemoSessionSpeaker
	{
		public static int SampleSessionSpeakerId0000 = DemoSession.SampleSessionId0000;
		public static int SampleSessionSpeakerId0001 = DemoUser.SampleUserId0000;
		public static int SampleSessionSpeakerId0100 = DemoSession.SampleSessionId0100;
		public static int SampleSessionSpeakerId0101 = DemoUser.SampleUserId0100;

		public static SessionSpeaker SampleSessionSpeaker00
		{
			get
			{
				return new SessionSpeaker()
				{
					SessionId = DemoSession.SampleSessionId0000,
					UserId = DemoUser.SampleUserId0000,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
                    SessionIdUserId = $"{DemoSession.SampleSessionId0000}{DemoUser.SampleUserId0000}"
                };
			}
		}
		public static SessionSpeaker SampleSessionSpeaker01
		{
			get
			{
				return new SessionSpeaker()
				{
                    SessionId = DemoSession.SampleSessionId0100,
                    UserId = DemoUser.SampleUserId0100,
                    DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
                    SessionIdUserId = $"{DemoSession.SampleSessionId0100}{DemoUser.SampleUserId0100}"
                };
			}
		}

	}
}
