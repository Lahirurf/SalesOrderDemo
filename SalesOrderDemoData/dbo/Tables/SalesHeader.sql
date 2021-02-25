CREATE TABLE [dbo].[SalesHeader]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerId] INT NOT NULL, 
    [Address1] NVARCHAR(100) NOT NULL, 
    [Address2] NVARCHAR(100) NOT NULL, 
    [Address3] NVARCHAR(100) NOT NULL, 
    [Suburb] NVARCHAR(50) NOT NULL, 
    [State] NVARCHAR(50) NOT NULL, 
    [PostCode] NVARCHAR(50) NOT NULL, 
    [InvoiceNo] NVARCHAR(50) NOT NULL, 
    [InvoiceDate] DATE NOT NULL, 
    [ReferenceNo] NVARCHAR(50) NOT NULL, 
    [Note] NVARCHAR(200) NOT NULL,
    [TotalExcl] MONEY NOT NULL, 
    [TotalTax] MONEY NOT NULL, 
    [TotalIncl] MONEY NOT NULL,
    [CreatedDateUTC] DATETIME2 NOT NULL DEFAULT getutcdate(),      
    CONSTRAINT [FK_SalesHeader_Client] FOREIGN KEY ([CustomerId]) REFERENCES [Client]([DCLink])
)
