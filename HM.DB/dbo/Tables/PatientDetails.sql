CREATE TABLE [dbo].[PatientDetails] (
    [PatientId]       INT primary key IDENTITY (1, 1) NOT NULL,
    [PatientFullName] VARCHAR (50) NULL,
    [Gender]          CHAR (1)     NULL,
    [BloodGroup]      VARCHAR (10) NULL,
    [Phone]           VARCHAR (15) NULL,
    [Email]           VARCHAR (30) NULL,
    [Condition]       VARCHAR (30) NULL,
    [AdmissionDate]   DATE         NULL,
    [DOB]             DATE         NULL,
    [Age]             AS           (datediff(year,[DOB],getdate())),
    [IsActive] BIT NOT NULL DEFAULT 1
   );

