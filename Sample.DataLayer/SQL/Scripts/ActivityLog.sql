CREATE TABLE [dbo].[ActivityLog] (
    [Id]                   BIGINT         IDENTITY (1, 1) NOT NULL,
    [RequestId]            NVARCHAR (200) NOT NULL,
    [RequestIp]            NVARCHAR (100) NOT NULL,
    [RequestMethod]        VARCHAR (10)   NOT NULL,
    [RequestUrl]           VARCHAR (100)  NOT NULL,
    [Controller]           VARCHAR (100)  NOT NULL,
    [Action]               VARCHAR (50)   NOT NULL,
    [RequestQueryString]   VARCHAR (512)  NULL,
    [ResponseStatusCode]   VARCHAR (10)   NOT NULL,
    [Level]                VARCHAR (5)    NOT NULL,
    [CallSite]             VARCHAR (100)  NOT NULL,
    [Message]              VARCHAR (MAX)  NULL,
    [UserIdentityId]       VARCHAR (50)   NULL,
    [UserIdentityUsername] VARCHAR (100)  NULL,
    [LogTime]              DATETIME       CONSTRAINT [DF_ActivityLog_LogTime_SYSDATETIMEOFFSET] DEFAULT (sysdatetimeoffset()) NOT NULL,
    CONSTRAINT [PK_ActivityLog_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

