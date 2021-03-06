-- Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
-- See License.txt in the project root for license information.

CREATE TABLE Settings
(
	Id		INT IDENTITY NOT NULL,
	Active	BIT NOT NULL DEFAULT 1,

	[Name]	VARCHAR(100) NOT NULL DEFAULT '',
	[Value]	VARCHAR(4000) NOT NULL DEFAULT '',

	CONSTRAINT PK_Settings PRIMARY KEY (Id)
)
