Insert into InputType (Title, isVisible, Area)
values 
('Lab', 1, 1),
('Refinery', 1,2),
('Mill',1,3)


Insert into Runsheet (SheetName, SheetKey, Sortorder, InputTypeID)
values
('Glucose','LAB_GLUC', 1, (select id from InputType where Title = 'Lab')),
('Fructose','LAB_FRUC', 2, (select id from InputType where Title = 'Lab')),
('Glucose', 'REF_GLUC',1, (select id from InputType where Title ='Refinery'))


Insert into SubSection (SubSectionName, SortOrder, RunsheetID)
values
('', 0, (select id from Runsheets where SheetKey ='LAB_GLUC')),
('Section 1', 1, (select id from Runsheets where SheetKey ='LAB_GLUC')),
('Section 2', 2, (select id from Runsheets where SheetKey ='LAB_GLUC')),
('Section 3', 3, (select id from Runsheets where SheetKey ='LAB_GLUC')),

Insert Into Datafield (DataKey, Name, Description, DataType, SubSectionID, SortOrder, MinValue, MaxValue, isVisible, CssClass)
values 
('LAB_GLUC_TIME' 'Time','Time', 3, (select id from subsection where name = '' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 1, null,null,1,'lab-gluc-time'),
('LAB_GLUC_Initials' 'Time','Time', 4, (select id from subsection where name = '' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 2, null,null,1,'lab-gluc-initials'),
('LAB_GLUC_PERC_GLUC' '% Glucose','% Glucose', 1, (select id from subsection where name = 'section 1' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 3, 0.00,100.00,1,'lab-gluc-perc-gluc'),
('LAB_GLUC_PERC_FRUC' '% Fructose','% Fructose', 1, (select id from subsection where name = 'section 1' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 4, 0.00,100.00,1,'lab-gluc-perc-fruc'),
('LAB_GLUC_PERC_SUCR' '% Sucrose','% Sucrose', 1, (select id from subsection where name = 'section 1' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 5, 0.00,100.00,1,'lab-gluc-perc-sucr'),
('LAB_GLUC_PERC_GF4' '% GF 4','% GF 4', 1, (select id from subsection where name = 'section 2' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 6, 0.00,100.00,1,'lab-gluc-perc-gf4'),
('LAB_GLUC_PERC_GF3' '% GF 3','% GF 3', 1, (select id from subsection where name = 'section 2' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 7, 0.00,100.00,1,'lab-gluc-perc-gf3'),
('LAB_GLUC_PERC_GF2' '% GF 2','% GF 2', 1, (select id from subsection where name = 'section 2' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 8, 0.00,100.00,1,'lab-gluc-perc-gf2'),
('LAB_GLUC_PERC_TOTAL_FOS' '% Total FOS','% Total FOS', 1, (select id from subsection where name = 'section 3' and runsheetid = (select id from Runsheets where SheetKey ='LAB_GLUC')
, 8, 0.00,100.00,1,'lab-gluc-perc-fos')



