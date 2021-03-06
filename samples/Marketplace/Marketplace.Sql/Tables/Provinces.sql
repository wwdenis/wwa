-- Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
-- See License.txt in the project root for license information.

CREATE TABLE Provinces
(
	Id		INT IDENTITY NOT NULL,
	Active	BIT NOT NULL DEFAULT 1,

	[Name]			VARCHAR(50) NOT NULL DEFAULT '',
	Abbreviation	VARCHAR(5) NOT NULL DEFAULT '',

	CountryId		INT NOT NULL,

	CONSTRAINT PK_Provinces PRIMARY KEY (Id),
	CONSTRAINT UK_Provinces UNIQUE (CountryId, [Name]),
	CONSTRAINT FK_Provinces_Countries FOREIGN KEY (CountryId) REFERENCES Countries (Id)
)
