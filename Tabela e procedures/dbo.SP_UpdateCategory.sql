CREATE PROCEDURE [dbo].[SP_UpdateCategory]
	@Value decimal,
	@ClientSector varchar(10),
	@Risk varchar(10),
	@ValueGreaterThan bit,
	@Active bit,
	@Id int
AS
	UPDATE Category set Value = @Value, ClientSector = @ClientSector, Risk = @Risk, Active =@Active, ValueGreaterThan = @ValueGreaterThan
	where Id = @Id