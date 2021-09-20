drop Table if exists ReportDataEntry
drop Table if exists ReportEntry
drop Table if exists DatafieldReferences
drop Table if exists DatafieldDropdownData
drop Table if exists Datafield
drop Table if exists SubSection
drop Table if exists Runsheet
drop Table if exists InputType
Create Table InputType(
ID int Identity(1,1) Primary Key,
Title varchar(1000),
isVisible int,
Area int,
)

Create Table Runsheet(
ID int Identity(1,1) Primary Key,
SheetName varchar(1000),
SheetKey varchar(1000),
SortOrder int,
InputTypeID int References InputType(ID)
)

Create Table SubSection(
ID int Identity(1,1) Primary Key,
SubSectionName varchar(1000),
SortOrder int,
RunsheetID int References Runsheet(ID)
)

create table Datafield (
ID int Identity(1,1) Primary Key,
DataKey varchar(1000) unique,
Name varchar(1000),
Description varchar(1000),
DataType int,
SubSectionID int References Subsection(ID),
SortOrder int,
MinValue decimal(10,4),
MaxValue decimal(10,4),
isVisible int,
CssClass varchar(1000)
)

Create Table DatafieldDropdownData (
ID int Identity(1,1) Primary Key,
DataFieldID int References DataField(ID),
ItemValue varchar(100),
ItemText varchar(1000)
)

Create Table DatafieldReferences (
ID int Identity(1,1) Primary Key,
SourceDatafieldKey varchar(1000) References Datafield(DataKey),
TargetDataFieldKey varchar(1000) References Datafield(DataKey)
)	

Create Table ReportEntry (
ID int Identity(1,1) Primary Key,
CreateDate datetime,
LastMod datetime, 
ReportDate datetime,
RunsheetID int References Runsheet(ID),
Col int
)

Create Table ReportDataEntry(
ID int Identity(1,1) Primary Key,
ReportEntryID int References ReportEntry(ID),
DataFieldID int References Datafield(ID),
Val decimal(18,6),
Flag int,
Qualitative varchar(1000)
)