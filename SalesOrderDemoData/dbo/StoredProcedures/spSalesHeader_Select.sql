CREATE PROCEDURE [dbo].[spSalesHeader_Select]
AS
begin
select a.Id,a.CustomerId,a.Address1,a.Address2,a.Address3,a.Suburb,
a.[State],a.PostCode,a.InvoiceNo,a.InvoiceDate,a.ReferenceNo,a.Note,
a.TotalExcl,a.TotalTax,a.TotalIncl
from SalesHeader a;
end