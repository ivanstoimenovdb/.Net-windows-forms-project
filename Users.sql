﻿CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] NCHAR(20) NOT NULL, 
    [Password] NCHAR(20) NOT NULL, 
    [FacNumber] NCHAR(10) NOT NULL, 
    [Role] INT NOT NULL
)
