INSERT INTO Forums (created,Title,[Description], ImageUrl)
VALUES
(GETDATE(),'Python','A popular dynamic, strongly-typed programmng language','/images/forum/py.png'),
(GETDATE(),'C#','A popular dynamic, strongly-typed programmng language','/images/forum/csharp.png'),
(GETDATE(),'JavaScript','A popular dynamic, strongly-typed programmng language','/images/forum/js.png'),
(GETDATE(),'PHP','A popular dynamic, strongly-typed programmng language','/images/forum/php.png')
Select * from Forums