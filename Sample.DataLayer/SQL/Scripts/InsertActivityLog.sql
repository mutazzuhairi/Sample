CREATE procedure [dbo].[InsertActivityLog] 
(
	@RequestId nvarchar(200),
	@RequestIp nvarchar(100),
	@RequestMethod varchar(10),
	@RequestUrl varchar(100),
	@Controller varchar(100),
	@Action varchar(50),
	@RequestQueryString varchar(512),
	@ResponseStatusCode varchar(10),
	@Level varchar(5),
	@CallSite varchar(100),
	@Message varchar(max),
	@UserIdentityId varchar(50),
	@UserIdentityUsername varchar(100)
	
)
as

insert into dbo.[ActivityLog]
(
	[RequestId],
	[RequestIp],
	[RequestMethod],
	[RequestUrl],
	[Controller],
	[Action],
	[RequestQueryString],
	[ResponseStatusCode],
	[Level],
	[CallSite],
	[Message],
	[UserIdentityId],
	[UserIdentityUsername]
)
values
(
	@RequestId,
	@RequestIp,
	@RequestMethod,
	@RequestUrl,
	@Controller,
	@Action,
	@RequestQueryString,
	@ResponseStatusCode,
	@Level,
	@CallSite,
	@Message,
	@UserIdentityId,
	@UserIdentityUsername
)