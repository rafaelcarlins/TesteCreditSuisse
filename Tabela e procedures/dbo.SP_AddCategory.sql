CREATE PROCEDURE [dbo].[SP_AddCategory]
	@Value decimal,
	@Risk varchar(20),
	@ClientSector varchar(10),
	@Active bit,
	@ValueGreaterThan bit
AS
	INSERT INTO  Category(Value, Risk, ClientSector, Active, ValueGreaterThan) 
	VALUES (@Value, @Risk, @ClientSector, @Active, @ValueGreaterThan)