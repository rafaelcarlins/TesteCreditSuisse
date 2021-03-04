CREATE PROCEDURE [dbo].[SP_DeleteCategory]
	@Id int 
AS
	Delete from Category where Id = @Id