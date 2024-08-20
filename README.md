Query to create db 

CREATE TABLE [dbo].[Student] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [Class]       NVARCHAR (50) NULL,
    [Address]     NVARCHAR (50) NULL,
    [PhoneNumber] BIGINT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
