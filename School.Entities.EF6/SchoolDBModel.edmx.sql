
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/10/2018 21:26:20
-- Generated from EDMX file: C:\ClonGit\School.Entities.EF6\SchoolDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SchoolDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ADDRESS_ZIPCODE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Address] DROP CONSTRAINT [FK_ADDRESS_ZIPCODE];
GO
IF OBJECT_ID(N'[dbo].[FK_CITY_STATE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[City] DROP CONSTRAINT [FK_CITY_STATE];
GO
IF OBJECT_ID(N'[dbo].[FK_Course_Schedule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK_Course_Schedule];
GO
IF OBJECT_ID(N'[dbo].[FK_COURSE_SCHOOL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK_COURSE_SCHOOL];
GO
IF OBJECT_ID(N'[dbo].[FK_COURSE_SIGNATURES]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK_COURSE_SIGNATURES];
GO
IF OBJECT_ID(N'[dbo].[FK_COURSE_TEACHER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK_COURSE_TEACHER];
GO
IF OBJECT_ID(N'[dbo].[FK_GRADE_STUDENT]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grade] DROP CONSTRAINT [FK_GRADE_STUDENT];
GO
IF OBJECT_ID(N'[dbo].[FK_GRADE_TEACHER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grade] DROP CONSTRAINT [FK_GRADE_TEACHER];
GO
IF OBJECT_ID(N'[dbo].[FK_INSCRIPTION_SCHOOL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inscription] DROP CONSTRAINT [FK_INSCRIPTION_SCHOOL];
GO
IF OBJECT_ID(N'[dbo].[FK_INSCRIPTION_STUDENT]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inscription] DROP CONSTRAINT [FK_INSCRIPTION_STUDENT];
GO
IF OBJECT_ID(N'[dbo].[FK_PERSON_ADDRESS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [FK_PERSON_ADDRESS];
GO
IF OBJECT_ID(N'[dbo].[FK_PERSON_ROL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [FK_PERSON_ROL];
GO
IF OBJECT_ID(N'[dbo].[FK_PERSON_ROLES]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SchoolUser] DROP CONSTRAINT [FK_PERSON_ROLES];
GO
IF OBJECT_ID(N'[dbo].[FK_Schedule_WeekDay]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Schedule] DROP CONSTRAINT [FK_Schedule_WeekDay];
GO
IF OBJECT_ID(N'[dbo].[FK_SCHOOL_ADDRESS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[School] DROP CONSTRAINT [FK_SCHOOL_ADDRESS];
GO
IF OBJECT_ID(N'[dbo].[FK_SCHOOL_SCHOOLTYPE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[School] DROP CONSTRAINT [FK_SCHOOL_SCHOOLTYPE];
GO
IF OBJECT_ID(N'[dbo].[FK_STUDENT_PERSON]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_STUDENT_PERSON];
GO
IF OBJECT_ID(N'[dbo].[FK_TEACHER_PERSON]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK_TEACHER_PERSON];
GO
IF OBJECT_ID(N'[dbo].[FK_WORK_SCHOOL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Work] DROP CONSTRAINT [FK_WORK_SCHOOL];
GO
IF OBJECT_ID(N'[dbo].[FK_WORK_TEACHER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Work] DROP CONSTRAINT [FK_WORK_TEACHER];
GO
IF OBJECT_ID(N'[dbo].[FK_ZIPCODE_CITY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ZipCode] DROP CONSTRAINT [FK_ZIPCODE_CITY];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Address]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Address];
GO
IF OBJECT_ID(N'[dbo].[City]', 'U') IS NOT NULL
    DROP TABLE [dbo].[City];
GO
IF OBJECT_ID(N'[dbo].[Course]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Course];
GO
IF OBJECT_ID(N'[dbo].[Grade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grade];
GO
IF OBJECT_ID(N'[dbo].[Inscription]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inscription];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Schedule]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schedule];
GO
IF OBJECT_ID(N'[dbo].[School]', 'U') IS NOT NULL
    DROP TABLE [dbo].[School];
GO
IF OBJECT_ID(N'[dbo].[SchoolType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SchoolType];
GO
IF OBJECT_ID(N'[dbo].[SchoolUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SchoolUser];
GO
IF OBJECT_ID(N'[dbo].[Signatures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Signatures];
GO
IF OBJECT_ID(N'[dbo].[State]', 'U') IS NOT NULL
    DROP TABLE [dbo].[State];
GO
IF OBJECT_ID(N'[dbo].[Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Student];
GO
IF OBJECT_ID(N'[dbo].[Teacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teacher];
GO
IF OBJECT_ID(N'[dbo].[WeekDay]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WeekDay];
GO
IF OBJECT_ID(N'[dbo].[Work]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Work];
GO
IF OBJECT_ID(N'[dbo].[ZipCode]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ZipCode];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Address'
CREATE TABLE [dbo].[Address] (
    [AddressId] int IDENTITY(1,1) NOT NULL,
    [Address1] varchar(200)  NOT NULL,
    [Neighborhood] int  NOT NULL,
    [ExtNum] varchar(10)  NOT NULL,
    [IntNum] varchar(10)  NULL
);
GO

-- Creating table 'City'
CREATE TABLE [dbo].[City] (
    [CityId] int IDENTITY(1,1) NOT NULL,
    [StateId] int  NOT NULL,
    [CityName] varchar(50)  NOT NULL
);
GO

-- Creating table 'Course'
CREATE TABLE [dbo].[Course] (
    [CourseId] varchar(30)  NOT NULL,
    [SignaturesId] int  NOT NULL,
    [SchoolId] varchar(50)  NOT NULL,
    [TeacherId] int  NOT NULL,
    [MinToPass] int  NULL,
    [Year] int  NOT NULL,
    [Credits] int  NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [IsActive] bit  NOT NULL,
    [ScheduleId] int  NOT NULL
);
GO

-- Creating table 'Grade'
CREATE TABLE [dbo].[Grade] (
    [CourseId] varchar(30)  NOT NULL,
    [StudentId] int  NOT NULL,
    [Grade1] varchar(5)  NOT NULL
);
GO

-- Creating table 'Inscription'
CREATE TABLE [dbo].[Inscription] (
    [StudentId] int  NOT NULL,
    [SchoolId] varchar(50)  NOT NULL,
    [InscriptionDate] datetime  NOT NULL
);
GO

-- Creating table 'Person'
CREATE TABLE [dbo].[Person] (
    [PersonId] int IDENTITY(1,1) NOT NULL,
    [PersonName] varchar(50)  NOT NULL,
    [PersonAge] int  NOT NULL,
    [AddressId] int  NOT NULL,
    [CURP] varbinary(18)  NOT NULL,
    [Phone] varchar(12)  NULL,
    [Email] varchar(50)  NULL,
    [RolId] int  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [RolId] int IDENTITY(1,1) NOT NULL,
    [RolName] varchar(50)  NOT NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'Schedule'
CREATE TABLE [dbo].[Schedule] (
    [ScheduleId] int IDENTITY(1,1) NOT NULL,
    [WdId] int  NOT NULL,
    [StartTime] time  NOT NULL,
    [EndTime] time  NOT NULL
);
GO

-- Creating table 'School'
CREATE TABLE [dbo].[School] (
    [SchoolId] varchar(50)  NOT NULL,
    [AddressId] int  NOT NULL,
    [SchoolName] varchar(100)  NOT NULL,
    [SchoolType] int  NOT NULL,
    [MinToPass] int  NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'SchoolType'
CREATE TABLE [dbo].[SchoolType] (
    [SchoolTypeId] int IDENTITY(1,1) NOT NULL,
    [Type] varchar(20)  NOT NULL
);
GO

-- Creating table 'SchoolUser'
CREATE TABLE [dbo].[SchoolUser] (
    [SchoolUserId] int IDENTITY(1,1) NOT NULL,
    [RolId] int  NOT NULL,
    [UserName] varchar(50)  NOT NULL,
    [Password] varchar(15)  NOT NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'Signatures'
CREATE TABLE [dbo].[Signatures] (
    [SignaturesId] int IDENTITY(1,1) NOT NULL,
    [SignaturesName] varchar(20)  NOT NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'State'
CREATE TABLE [dbo].[State] (
    [StateId] int IDENTITY(1,1) NOT NULL,
    [StateName] varchar(50)  NOT NULL
);
GO

-- Creating table 'Student'
CREATE TABLE [dbo].[Student] (
    [PersonId] int  NOT NULL,
    [StudentId] int IDENTITY(1,1) NOT NULL,
    [Account] varchar(15)  NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'Teacher'
CREATE TABLE [dbo].[Teacher] (
    [PersonId] int  NOT NULL,
    [TeacherId] int IDENTITY(1,1) NOT NULL,
    [RFC] varchar(13)  NOT NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'WeekDay'
CREATE TABLE [dbo].[WeekDay] (
    [WdId] int IDENTITY(1,1) NOT NULL,
    [Day] varchar(10)  NOT NULL
);
GO

-- Creating table 'ZipCode'
CREATE TABLE [dbo].[ZipCode] (
    [Neighborhood] int  NOT NULL,
    [CityId] int  NOT NULL,
    [ZCName] varchar(59)  NOT NULL
);
GO

-- Creating table 'Work'
CREATE TABLE [dbo].[Work] (
    [School_SchoolId] varchar(50)  NOT NULL,
    [Teacher_TeacherId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AddressId] in table 'Address'
ALTER TABLE [dbo].[Address]
ADD CONSTRAINT [PK_Address]
    PRIMARY KEY CLUSTERED ([AddressId] ASC);
GO

-- Creating primary key on [CityId] in table 'City'
ALTER TABLE [dbo].[City]
ADD CONSTRAINT [PK_City]
    PRIMARY KEY CLUSTERED ([CityId] ASC);
GO

-- Creating primary key on [CourseId] in table 'Course'
ALTER TABLE [dbo].[Course]
ADD CONSTRAINT [PK_Course]
    PRIMARY KEY CLUSTERED ([CourseId] ASC);
GO

-- Creating primary key on [CourseId], [StudentId] in table 'Grade'
ALTER TABLE [dbo].[Grade]
ADD CONSTRAINT [PK_Grade]
    PRIMARY KEY CLUSTERED ([CourseId], [StudentId] ASC);
GO

-- Creating primary key on [StudentId], [SchoolId] in table 'Inscription'
ALTER TABLE [dbo].[Inscription]
ADD CONSTRAINT [PK_Inscription]
    PRIMARY KEY CLUSTERED ([StudentId], [SchoolId] ASC);
GO

-- Creating primary key on [PersonId] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [PK_Person]
    PRIMARY KEY CLUSTERED ([PersonId] ASC);
GO

-- Creating primary key on [RolId] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([RolId] ASC);
GO

-- Creating primary key on [ScheduleId] in table 'Schedule'
ALTER TABLE [dbo].[Schedule]
ADD CONSTRAINT [PK_Schedule]
    PRIMARY KEY CLUSTERED ([ScheduleId] ASC);
GO

-- Creating primary key on [SchoolId] in table 'School'
ALTER TABLE [dbo].[School]
ADD CONSTRAINT [PK_School]
    PRIMARY KEY CLUSTERED ([SchoolId] ASC);
GO

-- Creating primary key on [SchoolTypeId] in table 'SchoolType'
ALTER TABLE [dbo].[SchoolType]
ADD CONSTRAINT [PK_SchoolType]
    PRIMARY KEY CLUSTERED ([SchoolTypeId] ASC);
GO

-- Creating primary key on [SchoolUserId] in table 'SchoolUser'
ALTER TABLE [dbo].[SchoolUser]
ADD CONSTRAINT [PK_SchoolUser]
    PRIMARY KEY CLUSTERED ([SchoolUserId] ASC);
GO

-- Creating primary key on [SignaturesId] in table 'Signatures'
ALTER TABLE [dbo].[Signatures]
ADD CONSTRAINT [PK_Signatures]
    PRIMARY KEY CLUSTERED ([SignaturesId] ASC);
GO

-- Creating primary key on [StateId] in table 'State'
ALTER TABLE [dbo].[State]
ADD CONSTRAINT [PK_State]
    PRIMARY KEY CLUSTERED ([StateId] ASC);
GO

-- Creating primary key on [StudentId] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [PK_Student]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- Creating primary key on [TeacherId] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [PK_Teacher]
    PRIMARY KEY CLUSTERED ([TeacherId] ASC);
GO

-- Creating primary key on [WdId] in table 'WeekDay'
ALTER TABLE [dbo].[WeekDay]
ADD CONSTRAINT [PK_WeekDay]
    PRIMARY KEY CLUSTERED ([WdId] ASC);
GO

-- Creating primary key on [Neighborhood] in table 'ZipCode'
ALTER TABLE [dbo].[ZipCode]
ADD CONSTRAINT [PK_ZipCode]
    PRIMARY KEY CLUSTERED ([Neighborhood] ASC);
GO

-- Creating primary key on [School_SchoolId], [Teacher_TeacherId] in table 'Work'
ALTER TABLE [dbo].[Work]
ADD CONSTRAINT [PK_Work]
    PRIMARY KEY CLUSTERED ([School_SchoolId], [Teacher_TeacherId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Neighborhood] in table 'Address'
ALTER TABLE [dbo].[Address]
ADD CONSTRAINT [FK_ADDRESS_ZIPCODE]
    FOREIGN KEY ([Neighborhood])
    REFERENCES [dbo].[ZipCode]
        ([Neighborhood])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ADDRESS_ZIPCODE'
CREATE INDEX [IX_FK_ADDRESS_ZIPCODE]
ON [dbo].[Address]
    ([Neighborhood]);
GO

-- Creating foreign key on [AddressId] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [FK_PERSON_ADDRESS]
    FOREIGN KEY ([AddressId])
    REFERENCES [dbo].[Address]
        ([AddressId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PERSON_ADDRESS'
CREATE INDEX [IX_FK_PERSON_ADDRESS]
ON [dbo].[Person]
    ([AddressId]);
GO

-- Creating foreign key on [AddressId] in table 'School'
ALTER TABLE [dbo].[School]
ADD CONSTRAINT [FK_SCHOOL_ADDRESS]
    FOREIGN KEY ([AddressId])
    REFERENCES [dbo].[Address]
        ([AddressId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SCHOOL_ADDRESS'
CREATE INDEX [IX_FK_SCHOOL_ADDRESS]
ON [dbo].[School]
    ([AddressId]);
GO

-- Creating foreign key on [StateId] in table 'City'
ALTER TABLE [dbo].[City]
ADD CONSTRAINT [FK_CITY_STATE]
    FOREIGN KEY ([StateId])
    REFERENCES [dbo].[State]
        ([StateId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CITY_STATE'
CREATE INDEX [IX_FK_CITY_STATE]
ON [dbo].[City]
    ([StateId]);
GO

-- Creating foreign key on [CityId] in table 'ZipCode'
ALTER TABLE [dbo].[ZipCode]
ADD CONSTRAINT [FK_ZIPCODE_CITY]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[City]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZIPCODE_CITY'
CREATE INDEX [IX_FK_ZIPCODE_CITY]
ON [dbo].[ZipCode]
    ([CityId]);
GO

-- Creating foreign key on [ScheduleId] in table 'Course'
ALTER TABLE [dbo].[Course]
ADD CONSTRAINT [FK_Course_Schedule]
    FOREIGN KEY ([ScheduleId])
    REFERENCES [dbo].[Schedule]
        ([ScheduleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Course_Schedule'
CREATE INDEX [IX_FK_Course_Schedule]
ON [dbo].[Course]
    ([ScheduleId]);
GO

-- Creating foreign key on [SchoolId] in table 'Course'
ALTER TABLE [dbo].[Course]
ADD CONSTRAINT [FK_COURSE_SCHOOL]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[School]
        ([SchoolId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_COURSE_SCHOOL'
CREATE INDEX [IX_FK_COURSE_SCHOOL]
ON [dbo].[Course]
    ([SchoolId]);
GO

-- Creating foreign key on [SignaturesId] in table 'Course'
ALTER TABLE [dbo].[Course]
ADD CONSTRAINT [FK_COURSE_SIGNATURES]
    FOREIGN KEY ([SignaturesId])
    REFERENCES [dbo].[Signatures]
        ([SignaturesId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_COURSE_SIGNATURES'
CREATE INDEX [IX_FK_COURSE_SIGNATURES]
ON [dbo].[Course]
    ([SignaturesId]);
GO

-- Creating foreign key on [TeacherId] in table 'Course'
ALTER TABLE [dbo].[Course]
ADD CONSTRAINT [FK_COURSE_TEACHER]
    FOREIGN KEY ([TeacherId])
    REFERENCES [dbo].[Teacher]
        ([TeacherId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_COURSE_TEACHER'
CREATE INDEX [IX_FK_COURSE_TEACHER]
ON [dbo].[Course]
    ([TeacherId]);
GO

-- Creating foreign key on [CourseId] in table 'Grade'
ALTER TABLE [dbo].[Grade]
ADD CONSTRAINT [FK_GRADE_TEACHER]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Course]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [StudentId] in table 'Grade'
ALTER TABLE [dbo].[Grade]
ADD CONSTRAINT [FK_GRADE_STUDENT]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Student]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GRADE_STUDENT'
CREATE INDEX [IX_FK_GRADE_STUDENT]
ON [dbo].[Grade]
    ([StudentId]);
GO

-- Creating foreign key on [SchoolId] in table 'Inscription'
ALTER TABLE [dbo].[Inscription]
ADD CONSTRAINT [FK_INSCRIPTION_SCHOOL]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[School]
        ([SchoolId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_INSCRIPTION_SCHOOL'
CREATE INDEX [IX_FK_INSCRIPTION_SCHOOL]
ON [dbo].[Inscription]
    ([SchoolId]);
GO

-- Creating foreign key on [StudentId] in table 'Inscription'
ALTER TABLE [dbo].[Inscription]
ADD CONSTRAINT [FK_INSCRIPTION_STUDENT]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Student]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RolId] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [FK_PERSON_ROL]
    FOREIGN KEY ([RolId])
    REFERENCES [dbo].[Roles]
        ([RolId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PERSON_ROL'
CREATE INDEX [IX_FK_PERSON_ROL]
ON [dbo].[Person]
    ([RolId]);
GO

-- Creating foreign key on [PersonId] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [FK_STUDENT_PERSON]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[Person]
        ([PersonId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_STUDENT_PERSON'
CREATE INDEX [IX_FK_STUDENT_PERSON]
ON [dbo].[Student]
    ([PersonId]);
GO

-- Creating foreign key on [PersonId] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [FK_TEACHER_PERSON]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[Person]
        ([PersonId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TEACHER_PERSON'
CREATE INDEX [IX_FK_TEACHER_PERSON]
ON [dbo].[Teacher]
    ([PersonId]);
GO

-- Creating foreign key on [RolId] in table 'SchoolUser'
ALTER TABLE [dbo].[SchoolUser]
ADD CONSTRAINT [FK_PERSON_ROLES]
    FOREIGN KEY ([RolId])
    REFERENCES [dbo].[Roles]
        ([RolId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PERSON_ROLES'
CREATE INDEX [IX_FK_PERSON_ROLES]
ON [dbo].[SchoolUser]
    ([RolId]);
GO

-- Creating foreign key on [WdId] in table 'Schedule'
ALTER TABLE [dbo].[Schedule]
ADD CONSTRAINT [FK_Schedule_WeekDay]
    FOREIGN KEY ([WdId])
    REFERENCES [dbo].[WeekDay]
        ([WdId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Schedule_WeekDay'
CREATE INDEX [IX_FK_Schedule_WeekDay]
ON [dbo].[Schedule]
    ([WdId]);
GO

-- Creating foreign key on [SchoolType] in table 'School'
ALTER TABLE [dbo].[School]
ADD CONSTRAINT [FK_SCHOOL_SCHOOLTYPE]
    FOREIGN KEY ([SchoolType])
    REFERENCES [dbo].[SchoolType]
        ([SchoolTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SCHOOL_SCHOOLTYPE'
CREATE INDEX [IX_FK_SCHOOL_SCHOOLTYPE]
ON [dbo].[School]
    ([SchoolType]);
GO

-- Creating foreign key on [School_SchoolId] in table 'Work'
ALTER TABLE [dbo].[Work]
ADD CONSTRAINT [FK_Work_School]
    FOREIGN KEY ([School_SchoolId])
    REFERENCES [dbo].[School]
        ([SchoolId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Teacher_TeacherId] in table 'Work'
ALTER TABLE [dbo].[Work]
ADD CONSTRAINT [FK_Work_Teacher]
    FOREIGN KEY ([Teacher_TeacherId])
    REFERENCES [dbo].[Teacher]
        ([TeacherId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Work_Teacher'
CREATE INDEX [IX_FK_Work_Teacher]
ON [dbo].[Work]
    ([Teacher_TeacherId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------