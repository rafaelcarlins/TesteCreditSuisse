CREATE PROCEDURE [dbo].[SP_TradeCategory]
	@ClientSector varchar(10),
	@value decimal
AS
DECLARE 
@val decimal
select @val=Value from Category

IF @value > @val
	select Risk from Category where ClientSector = @ClientSector and Active = 1
	and value >=@val and ValueGreaterThan = 1

else
select Risk from Category where ClientSector = @ClientSector and Active = 1
	and value <=@val and ValueGreaterThan = 0