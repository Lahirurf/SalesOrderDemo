CREATE PROCEDURE [dbo].[spClient_GetAll]
AS
begin
set nocount on;
select 
a.DCLink id,a.[Name],a.Physical1 address1,a.Physical2 address2,a.Physical3 address3,
a.Physical4 suburb,a.Physical5 [state],a.PhysicalPC postcode  
from Client a;
end
