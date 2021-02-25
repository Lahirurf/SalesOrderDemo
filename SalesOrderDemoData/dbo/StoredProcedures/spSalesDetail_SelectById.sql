CREATE PROCEDURE [dbo].[spSalesDetail_SelectById]
	@SalesHeaderId int
AS
begin
select i.Code ItemCode,a.Note,a.Quantity,a.Price,
a.Tax,a.ExclAmount,a.TaxAmount,a.InclAmount
from SalesDetail a
inner join StkItem i on i.StockLink = a.ItemId
where a.SalesHeaderId = @SalesHeaderId;
end
