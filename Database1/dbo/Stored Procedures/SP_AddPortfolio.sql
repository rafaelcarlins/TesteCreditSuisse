CREATE PROCEDURE [dbo].[SP_AddPortfolio]
	@Value int = 0,
	@ClientSector int
AS
	INSERT INTO  Trade (Value, CientSector) 
	VALUES (@Value, @ClientSector)

	
RETURN 0