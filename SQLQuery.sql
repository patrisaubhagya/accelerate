CREATE TABLE [Case]
(
	[CaseId] INT PRIMARY KEY,
	[CaseName] VARCHAR(50),
	[Challenge] VARCHAR(50),
	[Solution] VARCHAR(50),
	[Comments] VARCHAR(50)
)
GO

insert into [Case]  values(101,'Customer with other managed devices','Wifi connectivity complains','To simulate Customer premise issues','Client is happy')
insert into [Case] values(102,'Customer with other managed devices','Network issues','To repair the cable','Client is satisfied')
insert into [Case] values(103,'Customer with own device','Issue in Hardware connection ','To diagnose the connectivity','Client is unhappy')
insert into [Case] values(104,'Customer with office device','Issue in Keypad','To check the working of keypad','Client is happy')


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

insert into ContactDetails values(101,'Largest Provider',1,'111111111','PPP_NNN','ZZZZ_MMM')
insert into ContactDetails values (102,'Largest Provider2',2,'222222222','PPP_NNN','ZZZZ_MMM')
insert into ContactDetails  values(103,'Provider3',3,'563456','AAA_HFD','KYH_BBB')
insert into ContactDetails values (104,'Provider2',2,'222222222','JJU_VBN','MMM_AAA')



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

insert into DashBoard values (101,'Internal','Manufacturing','Software Product','2019-01-01','2021-06-27','Whole home')
insert into DashBoard values (102,'Internal','Manufacturing','Software Product','2020-06-04','2022-05-03','Whole home')
insert into DashBoard values(103,'Internal','Production','Hardware Product','2003-09-23','2004-01-18','Support system')
insert into Dashboard values(104,'Internal','Production','Hardware Product','2004-06-14','2005-01-01','Connection diagnose')



CREATE TABLE [ReportData]
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
GO


insert into ReportData values(101,'Revenue/SoW',20,300,'Null',0,0,'ManualTestCycletime',55,8,'Null',0,0,35,0,4,0)
insert into ReportData values(102,'Revenue/SoW',30,500,'Null',1,5,'ManualTestCycletime',65,2,'Null',2,4,67,9,2,1)
insert into ReportData values(103,'Revenue/SoW',64,899,'Null',6,8,'ManualTestCycletime',77,3,'Null',6,2,55,0,5,2)
insert into ReportData values(104,'Revenue/SoW',23,500,'Null',3,9,'ManualTestCycletime',23,5,'Null',7,0,4,0,9,2)


Select * from [Case]
select * from ContactDetails
select * from DashBoard
select * from ReportData

