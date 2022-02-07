CREATE procedure [dbo].[InsertApplicationLog] 
(
	@logger varchar(50),
	@requestId nvarchar(200),
	@level varchar(10),
	@callSite varchar(100),
	@type varchar(50),
	@message varchar(max),
	@stackTrace varchar(max),
	@innerException varchar(max),
	@additionalInfo varchar(max)
)
as

insert into dbo.ApplicationLog
(
	[Logger],
	[RequestId],
	[Level],
	CallSite,
	[Type],
	[Message],
	StackTrace,
	InnerException,
	AdditionalInfo
)
values
(
	@logger,
	@requestId,
	@level,
	@callSite,
	@type,
	@message,
	@stackTrace,
	@innerException,
	@additionalInfo
)