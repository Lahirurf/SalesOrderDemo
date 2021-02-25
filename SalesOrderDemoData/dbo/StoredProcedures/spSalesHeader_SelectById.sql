CREATE PROCEDURE [dbo].[spSalesHeader_SelectById]
	@Id int
AS
begin
select a.Id,b.[Name] CustomerName,a.Address1,a.Address2,a.Address3,a.Suburb,
a.[State],a.PostCode,a.InvoiceNo,a.InvoiceDate,a.ReferenceNo,a.Note,
a.TotalExcl,a.TotalTax,a.TotalIncl
from SalesHeader a
inner join Client b on a.CustomerId = b.DCLink
where a.Id = @Id;
end
