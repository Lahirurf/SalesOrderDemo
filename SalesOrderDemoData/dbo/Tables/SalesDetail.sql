CREATE TABLE [dbo].[SalesDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SalesHeaderId] INT NOT NULL, 
    [ItemId] INT NOT NULL, 
    [Note] NVARCHAR(100) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL, 
    [ExclAmount] MONEY NOT NULL, 
    [TaxAmount] MONEY NOT NULL, 
    [InclAmount] MONEY NOT NULL, 
    CONSTRAINT [FK_SalesDetail_SalesHeader] FOREIGN KEY ([SalesHeaderId]) REFERENCES [SalesHeader]([Id]), 
    CONSTRAINT [FK_SalesDetail_StkItem] FOREIGN KEY ([ItemId]) REFERENCES [StkItem]([StockLink])
)
