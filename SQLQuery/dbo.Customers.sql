CREATE TABLE [dbo].[Customers] (
    [Id]  INT        NOT NULL,
    [UserId]      INT        NULL,
    [CompanyName] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

