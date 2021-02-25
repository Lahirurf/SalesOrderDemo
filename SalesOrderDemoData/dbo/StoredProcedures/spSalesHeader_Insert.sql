CREATE PROCEDURE [dbo].[spSalesHeader_Insert]
@Identity int output,
@CustomerId int,
@Address1 nvarchar(100),
@Address2 nvarchar(100),
@Address3 nvarchar(100),
@Suburb nvarchar(50),
@State nvarchar(50),
@PostCode nvarchar(50),
@InvoiceNo nvarchar(50),
@InvoiceDate datetime2,
@ReferenceNo nvarchar(50),
@Note nvarchar(200),
@TotalExcl money,
@TotalTax money,
@TotalIncl money
AS
begin
insert into SalesHeader 
(CustomerId,Address1,Address2,Address3,Suburb,State,PostCode,InvoiceNo,InvoiceDate,ReferenceNo,
Note,TotalExcl,TotalTax,TotalIncl) values (@CustomerId,@Address1,@Address2,@Address3,@Suburb,@State,@PostCode,
@InvoiceNo,@InvoiceDate,@ReferenceNo,@Note,@TotalExcl,@TotalTax,@TotalIncl);
set @Identity = SCOPE_IDENTITY();
end
