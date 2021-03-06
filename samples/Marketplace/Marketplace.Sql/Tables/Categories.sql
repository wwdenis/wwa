-- Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
-- See License.txt in the project root for license information.

CREATE TABLE Categories
(	
	Id		INT IDENTITY NOT NULL,
	Active	BIT NOT NULL DEFAULT 1,
	[Name]	VARCHAR(50) NOT NULL DEFAULT '',

	CONSTRAINT PK_Categories PRIMARY KEY (Id),
	CONSTRAINT UK_Categories UNIQUE ([Name])
)
