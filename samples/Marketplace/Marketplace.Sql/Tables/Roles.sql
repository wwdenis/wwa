-- Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
-- See License.txt in the project root for license information.

CREATE TABLE Roles
(
	Id		INT IDENTITY NOT NULL,
	Active	BIT NOT NULL DEFAULT 1,

	[Name]	VARCHAR(512) NOT NULL DEFAULT '',
	IsAdmin	BIT NOT NULL DEFAULT 0,

	CONSTRAINT PK_Roles PRIMARY KEY (Id)
)
