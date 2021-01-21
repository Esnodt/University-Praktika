CREATE DATABASE [University]

USE [University]

CREATE TABLE [MainInfoTable]
(
[ID] INT IDENTITY (1,1) PRIMARY KEY,
[idLesson]					INT	CONSTRAINT MainInfoTable_idLesson_Lesson_NumberDiscipline							FOREIGN KEY REFERENCES [Lesson]([ID]) NOT NULL,
[idClassroom]				INT	CONSTRAINT MainInfoTable_idClassroom_Classroom_NumberClass							FOREIGN KEY REFERENCES [Classroom]([ID]) NOT NULL,
[idTeacher]					INT	CONSTRAINT MainInfoTable_idTeacher_Teacher_NumberTeacher							FOREIGN KEY REFERENCES [Teacher]([ID]) NOT NULL,
[idHeadOfTheDepartament]	INT	CONSTRAINT MainInfoTable_idHeadOfTheDepartament_HeadOfTheDepartament_NumberManager  FOREIGN KEY REFERENCES [HeadOfTheDepartament]([ID]) NOT NULL
)


CREATE TABLE [Lesson]
(
[ID] INT IDENTITY (1,1) PRIMARY KEY,
[NumberDiscipline] int NOT NULL,
[DisciplineName] NVARCHAR(MAX) NOT NULL,
[NumberOfHours] int  NOT NULL,
[ControlType] NVARCHAR(MAX) NOT NULL,
[DisciplineSection] NVARCHAR(MAX) NOT NULL
)

CREATE TABLE [Classroom]
(
[ID] INT IDENTITY (1,1) PRIMARY KEY,
[NumberClassrom] int NOT NULL,
[Party] nvarchar(MAX) NOT NULL,
[TheDateOfThe] DATE NOT NULL,
[LectureStartTime] nvarchar(max) NOT NULL,
[LectureEndTime] nvarchar(max) NOT NULL
)

CREATE TABLE [Teacher]
(
[ID] INT IDENTITY (1,1) PRIMARY KEY,
[NumberTeacher] int NOT NULL,
[FullName] NVARCHAR(MAX) NOT NULL,
[TheAddress] NVARCHAR(MAX) NOT NULL,
[Position] NVARCHAR(MAX) NOT NULL,
[AcademicDegree] NVARCHAR(MAX)NOT NULL
)

CREATE TABLE [HeadOfTheDepartament]
(
[ID] INT IDENTITY (1,1) PRIMARY KEY,
[NumberManager] int NOT NULL,
[NameManager] NVARCHAR(MAX) NOT NULL,
)

INSERT [HeadOfTheDepartament] ([NumberManager],[NameManager]) VALUES ('001','Иванов.И.И')
INSERT [Classroom] ([NumberClassrom], [Party], [TheDateOfThe], [LectureStartTime], [LectureEndTime]) VALUES ('01', '101', '12-12-12', '12:12:12', '12:12:12')
INSERT [Teacher] ([NumberTeacher],[FullName], [TheAddress], [Position], [AcademicDegree]) VALUES ('01', 'В.В.Вадимович', 'Оскара', 'Прфофесор', 'Магистр')
INSERT [Lesson] ([NumberDiscipline],[DisciplineName], [NumberOfHours], [ControlType], [DisciplineSection]) VALUES ('01', 'Геометрия', '12', 'Жесткий', 'Технические')
INSERT [MainInfoTable] ([idLesson], [idClassroom], [idTeacher], [idHeadOfTheDepartament]) VALUES ('1','1','1','1')


select * from [HeadOfTheDepartament]
select * from [Lesson]
select * from [MainInfoTable]