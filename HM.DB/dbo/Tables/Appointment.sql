CREATE TABLE [dbo].[Appointment] (
    [AppointmentId] INT      NULL,
    [ScheduledOn]   DATETIME NULL,
    [DateOfVisit]   DATE     NULL,
    [DepartmentId]  INT      NULL,
    [PatientId]     INT      NULL,
    FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([DepartmentId]),
    FOREIGN KEY ([PatientId]) REFERENCES [dbo].[PatientDetails] ([PatientId])
);

