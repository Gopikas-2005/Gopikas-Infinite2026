Create Table Holidays_Lists(Holiday_Date Date,Holiday_Name Varchar(100))
Insert into Holidays_Lists Values('2026-01-02','New year'),('2026-01-14','Pongal'),('2026-01-26','Republic Day'),('2026-08-15','Independence Day')
Go
Create or Alter Trigger Holidays_Creation
On Employees
After Insert,Update,Delete
As
Begin
Declare @HolidayName Varchar(100)
Select @HolidayName=Holiday_Name from Holidays_Lists Where Holiday_Date= Cast(GetDate() as Date)

If @HolidayName is not Null
Begin
 RAISERROR('Due to %s You cannot Manipulate Data',16,1,@HolidayName)
 RollBack Transaction
 Return
End
End
Select * from Holidays_Lists
Insert into  Holidays_Lists Values('2026-04-28','Office Holiday')

Insert into Employees Values(1,'Anand','IT',50000,40)
Update Employees Set Salary=60000 where Empno=1
Select * From Departments
Select * From Employees

