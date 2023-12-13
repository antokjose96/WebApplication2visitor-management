SET IDENTITY_INSERT [dbo].[Class] ON
INSERT INTO [dbo].[Class] ([VisitorId], [Name], [Email], [Phone_Number], [Age], [UserName], [Password]) VALUES (1, N'Anto Jose', N'antokjose96@gmail.com', N'0223004725', 27, N'antokjose96', N'453131')
INSERT INTO [dbo].[Class] ([VisitorId], [Name], [Email], [Phone_Number], [Age], [UserName], [Password]) VALUES (2, N'Kishore Chandran', N'rangerzindia@gmail.com', N'0224870200', 30, N'Kishore', N'Kishore')
INSERT INTO [dbo].[Class] ([VisitorId], [Name], [Email], [Phone_Number], [Age], [UserName], [Password]) VALUES (3, N'anandhumon', N'anandhumon@gmail.com', N'022046133', 30, N'anandhu', N'123455')
SET IDENTITY_INSERT [dbo].[Class] OFF

SET IDENTITY_INSERT [dbo].[Event] ON
INSERT INTO [dbo].[Event] ([EventId], [EventName], [Eventdate]) VALUES (1, N'paihia fire works', N'2023-12-02 11:52:00')
INSERT INTO [dbo].[Event] ([EventId], [EventName], [Eventdate]) VALUES (3, N'Paihia Concert', N'2023-12-23 21:04:00')
INSERT INTO [dbo].[Event] ([EventId], [EventName], [Eventdate]) VALUES (4, N'Paihia Flower Show', N'2023-12-26 11:06:00')
SET IDENTITY_INSERT [dbo].[Event] OFF