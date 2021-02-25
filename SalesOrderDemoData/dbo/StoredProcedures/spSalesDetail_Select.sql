CREATE PROCEDURE [dbo].[spSalesDetail_Select]
AS
begin
select a.Id,a.SalesHeaderId,a.ItemId,a.Note,a.Quantity,a.Price,
a.Tax,a.ExclAmount,a.TaxAmount,a.InclAmount
from SalesDetail a;
end
