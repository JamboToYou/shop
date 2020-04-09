CREATE TABLE [dbo].[Clients] (
[id_client] INT IDENTITY (1, 1) NOT NULL,
[Name] VARCHAR (50) NULL,
[Surname] VARCHAR (50) NULL,
PRIMARY KEY CLUSTERED ([id_client] ASC)
);
 
CREATE TABLE [dbo].[Orders] (
[id_order] INT IDENTITY (1, 1) NOT NULL,
[itemName] VARCHAR (50) NULL,
[itemPrice] INT NULL,
[id_client] INT NOT NULL, CONSTRAINT id_client FOREIGN KEY (id_client)
REFERENCES Clients (id_client),
PRIMARY KEY CLUSTERED ([id_order] ASC)
);