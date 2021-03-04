CREATE TABLE [dbo].[Trade] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [RiskId]      INT             NULL,
    [Value]       DECIMAL (12, 2) NULL,
    [CientSector] VARCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

