CREATE TABLE [dbo].[DeliveryUnit](
	[SLNo] [int] IDENTITY(1,1) PRIMARY KEY,
	[Client] [varchar](50) NULL,
	[CaseName] [varchar](50) NULL,
	[DeliveryManagerEmpID] [int] NULL,
	[SensitivityLevel] [varchar](50) NULL,
	[Vertical] [varchar](250) NULL,
	[Horizantal] [varchar](250) NULL,
	[StartDate] [varchar](15) NULL,
	[EndDate] [varchar](15) NULL,
	[Challenge] [varchar](250) NULL,
	[Solution] [varchar](250) NULL,
	[IncreaseOne] [varchar](250) NULL,
	[IncreaseOnePercentage] [varchar](10) NULL,
	[IncreaseOneBase] [varchar](10) NULL,
	[IncreaseTwo] [varchar](10) NULL,
	[IncreaseTwoPercentage] [varchar](10) NULL,
	[IncreaseTwoBase] [varchar](10) NULL,
	[DecreaseOne] [varchar](250) NULL,
	[DecreaseOnePercentage] [varchar](10) NULL,
	[DecreaseOneBase] [varchar](10) NULL,
	[DecreaseTwo] [varchar](10) NULL,
	[DecreaseTwoPercentage] [varchar](10) NULL,
	[DecreaseTwoBase] [varchar](10) NULL,
	[CommentOnOutcomes] [varchar](250) NULL,
	[IncreaseOneAfter] [varchar](10) NULL,
	[IncreaseTwoAfter] [varchar](10) NULL,
	[DecreaseOneAfter] [varchar](10) NULL,
	[DecreaseTwoAfter] [varchar](10) NULL,
	[DeliveryContacts] [varchar](100) NULL,
	[SearchWords] [varchar](250) NULL,
	[AnchorNameForEachUseCase] [varchar](250) NULL,
	[OfferingHead] [varchar](100) NULL,
	[DeliveryAnchor] [varchar](100) NULL,
	[IsActive] [int] NULL CONSTRAINT [DeliveryUnit_IsActive]  DEFAULT ((1)),
	[CreatedBy] [int] NULL,
	[CreatedOn] [datetime] NULL CONSTRAINT [DeliveryUnit_CreatedOn]  DEFAULT ((1)),
	[ModifiedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL
)

GO


--insert into [DeliveryUnit](Vertical,Horizantal) values('test','test')
--insert into [DeliveryUnit](Vertical,Horizantal) values('test1','test1')



