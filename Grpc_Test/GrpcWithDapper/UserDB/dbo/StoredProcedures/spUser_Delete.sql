CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id INT
AS
BEGIN
	UPDATE dbo.[User]
	SET Display=0
	WHERE Id = @Id;
END
