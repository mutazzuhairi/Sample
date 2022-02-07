CREATE TABLE [dbo].[ApplicationLog] (
    [Id]             BIGINT         IDENTITY (1, 1) NOT NULL,
    [Logger]         VARCHAR (50)   NOT NULL,
    [RequestId]      NVARCHAR (200) NULL,
    [Level]          VARCHAR (10)   NOT NULL,
    [CallSite]       VARCHAR (100)  NOT NULL,
    [Type]           VARCHAR (50)   NOT NULL,
    [Message]        VARCHAR (MAX)  NOT NULL,
    [StackTrace]     VARCHAR (MAX)  NOT NULL,
    [InnerException] VARCHAR (MAX)  NOT NULL,
    [AdditionalInfo] VARCHAR (MAX)  NOT NULL,
    [LogTime]        DATETIME       CONSTRAINT [DF_ApplicationLog_LogTime_SYSDATETIMEOFFSET] DEFAULT (sysdatetimeoffset()) NOT NULL,
    CONSTRAINT [PK_ApplicationLog_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

