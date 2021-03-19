CREATE TABLE [Case]
(
	[CaseId] INT PRIMARY KEY,
	[CaseName] VARCHAR(50),
	[Challenge] VARCHAR(50),
	[Solution] VARCHAR(50),
	[Comments] VARCHAR(50)
)
GO


CREATE TABLE [ContactDetails]
(
	[CaseId] INT FOREIGN KEY REFERENCES [Case](CaseId),
	[Client] VARCHAR(20),
	[DeliveryManager] NUMERIC(7),
	[DeliveryManagerId] VARCHAR(20),
	[DeliveryAnchor] VARCHAR(20),
	[OfferingHead] VARCHAR(20)	   
)
GO

CREATE TABLE [DashBoard]
(
	[CaseId] INT FOREIGN KEY REFERENCES [Case](CaseId) PRIMARY KEY,
	[SensitivityLevel] CHAR(8),
	[Vertical] VARCHAR(20),
	[Horizontal] VARCHAR(20),
	[StartDate] DATE,
	[EndDate] DATE,
	[SearchWords] VARCHAR(30)
)
GO

CREATE TABLE ReportData
(
	[CaseId] INT FOREIGN KEY REFERENCES [Case](CaseId) PRIMARY KEY,
	[Increase1] VARCHAR(20),
	[Increase1%] INT,
	[Increase1Base] INT,
	[Increase2] VARCHAR(20),
	[Increase2%] INT,
	[Increase2Base] INT,
	[Decrease1] VARCHAR(20),
	[Decrease1%] INT,
	[Decrease1Base] INT,
	[Decrease2] VARCHAR(20),
	[Decrease2%] INT,
	[Decrease2Base] INT,
	[Increase1After] INT,
	[Increase2After] INT,
	[Decrease1After] INT,
	[Decrease2After] INT
)
