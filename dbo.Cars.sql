CREATE TABLE [dbo].[Cars] (
    [CarID]        INT           IDENTITY (1, 1) NOT NULL,
    [BrandID]      INT           NOT NULL,
    [ColorID]      INT           NULL,
    [ModelYear]    NVARCHAR (25) NULL,
    [DailyPrice]   DECIMAL (18)  NULL,
    [Descriptions] NVARCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([CarID] ASC),
    FOREIGN KEY ([ColorID]) REFERENCES [dbo].[Colors] ([ColorID]),
    FOREIGN KEY ([BrandID]) REFERENCES [dbo].[Brands] ([BrandID])
);

INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	            ('1','1', '2', '2012', '100', 'Manuel Benzin'),
	            ('2', '1', '3', '2015', '150', 'Otomatik Dizel'),
	            ('3', '2', '1', '2017', '200', 'Otomatik Hybrid'),
	            ('4', '3', '3', '2014', '125', 'Manuel Dizel');
