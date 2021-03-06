-- Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
-- See License.txt in the project root for license information.

CREATE TABLE Features
(
	Id			INT IDENTITY NOT NULL,
	
	[Name]		VARCHAR(100) NOT NULL DEFAULT '',
	Detail		VARCHAR(200) NOT NULL DEFAULT '',
	[Path]		VARCHAR(100) NOT NULL DEFAULT '',

	ParentId	INT,

	CONSTRAINT PK_Features PRIMARY KEY (Id),
	CONSTRAINT UK_Features UNIQUE ([Path]),
	CONSTRAINT FK_Features_Parent FOREIGN KEY (ParentId) REFERENCES Features (Id)
)
