CREATE TABLE [dbo].[Cars] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]      INT           NOT NULL,
    [ColorId]      INT           NULL,
    [ModelYear]    NVARCHAR (25) NULL,
    [DailyPrice]   DECIMAL (18)  NULL,
    [Descriptions] NVARCHAR (25) NULL,
    
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ColorID]) REFERENCES [dbo].[Colors] ([Id]),
    FOREIGN KEY ([BrandID]) REFERENCES [dbo].[Brands] ([Id])
);

