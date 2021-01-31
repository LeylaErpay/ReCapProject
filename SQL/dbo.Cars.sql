CREATE TABLE [dbo].[Cars]
(
	[CarId] INT NOT NULL PRIMARY KEY, 
    [CarName] NCHAR(10) NOT NULL, 
    [ModelYear] INT NOT NULL, 
    [DailyPrice] INT NOT NULL, 
    [Description] NCHAR(10) NULL
)
