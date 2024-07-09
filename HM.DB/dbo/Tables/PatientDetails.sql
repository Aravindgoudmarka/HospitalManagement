CREATE TABLE [dbo].[PatientDetails] (
    [Id]              INT          NULL,
    [PatientId]       INT          IDENTITY (1, 1) NOT NULL,
    [PatientFullName] VARCHAR (50) NOT NULL,
    [Gender]          CHAR (1)     NOT NULL,
    [BloodGroup]      VARCHAR (10) NULL,
    [Phone]           VARCHAR (15) NOT NULL,
    [Email]           VARCHAR (30) NULL,
    [Condition]       VARCHAR (30) NULL,
    [AdmissionDate]   DATE         NULL,
    [DOB]             DATE         NULL,
    [Age]             AS           (datediff(year,[DOB],getdate())),
    CONSTRAINT [PK__PatientD__970EC3669CBD5C8F] PRIMARY KEY CLUSTERED ([PatientId] ASC)
);

