CREATE TABLE [dbo].[Category] (
    [Id]               INT             IDENTITY (1, 1) NOT NULL,
    [Risk]             VARCHAR (20)    NOT NULL,
    [Value]            DECIMAL (12, 2) NOT NULL,
    [ClientSector]     VARCHAR (10)    NOT NULL,
    [Active]           BIT             NOT NULL,
    [ValueGreaterThan] BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

