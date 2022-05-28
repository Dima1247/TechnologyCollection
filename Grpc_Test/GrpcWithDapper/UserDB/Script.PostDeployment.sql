IF NOT EXISTS (SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO dbo.[User] (FirstName, LastName)
	VALUES ('Dima', 'Palamachuk'),
	('Dasha', 'Palamarhcuk'),
	('Alex', 'Balanyuk')
END