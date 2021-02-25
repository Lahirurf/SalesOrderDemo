CREATE PROCEDURE [dbo].[spSalesDetail_Insert]	
	@SalesHeaderId INT,
	@ItemId INT,
	@Note NVARCHAR(100),
	@Quantity INT,
	@Price MONEY,
	@Tax MONEY, 
	@ExclAmount MONEY, 
	@TaxAmount MONEY, 
	@InclAmount MONEY 
AS
begin
insert into SalesDetail (ItemId,Note,Quantity,Price,Tax,ExclAmount,TaxAmount,InclAmount,SalesHeaderId)
values (@ItemId,@Note,@Quantity,@Price,@Tax,@ExclAmount,@TaxAmount,@InclAmount,@SalesHeaderId);
end
