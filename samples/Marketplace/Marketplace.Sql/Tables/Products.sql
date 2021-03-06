-- Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
-- See License.txt in the project root for license information.

CREATE TABLE Products
(
	Id			INT IDENTITY NOT NULL,
	Active		BIT NOT NULL DEFAULT 1,

	[Name]		VARCHAR(512) NOT NULL DEFAULT '',
	[Detail]	VARCHAR(512) NOT NULL DEFAULT '',

	Stock		INT NOT NULL DEFAULT 0,
	Price		NUMERIC (15, 3) NOT NULL DEFAULT 0,

	CategoryId	INT NOT NULL,
	DealerId	INT NOT NULL,

	[Image]		VARBINARY(MAX),
		
	CONSTRAINT PK_Products PRIMARY KEY (Id),
	CONSTRAINT UK_Products UNIQUE ([Name]),
	CONSTRAINT FK_Products_Categories FOREIGN KEY (CategoryId) REFERENCES Categories (Id),
	CONSTRAINT FK_Products_Dealers FOREIGN KEY (DealerId) REFERENCES Dealers (Id)
)
