CREATE PROCEDURE [dbo].[spStkItem_GetAll]
AS
begin
set nocount on;
select 
a.StockLink id,a.Code itemcode,a.Description_1 [description] 
from StkItem a;
end
