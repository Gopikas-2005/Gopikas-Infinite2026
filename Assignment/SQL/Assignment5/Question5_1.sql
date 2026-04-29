Create Procedure PaySlips_ListS
@EmpName Varchar(100)
As
Begin 
  Declare @Salary Float
  Declare @HRA Float
  Declare @DA Float
  Declare @PF Float
  Declare @IT Float
  Declare @Deductions Float
  Declare @GrossSalary Float
  Declare @NetSalary Float

  Select @Salary=Salary from Employees where EName=@EmpName
  Set @HRA=@Salary*0.10
  Set @DA=@Salary*0.20
  Set @PF=@Salary*0.08
  Set @IT=@Salary*0.05

  Set @Deductions=@PF+@IT
  Set @GrossSalary=@Salary+@HRA+@DA
  Set @NetSalary=@GrossSalary-@Deductions

  Select @EmpName as EmpName,
  @Salary as Salary,
  @HRA as HRA,
  @DA as DA,
  @PF as PF,
  @IT as IT,
  @Deductions as Deductions,
  @GrossSalary as GrossSalary,
  @NetSalary as NetSalary
End

Exec PaySlips_ListS @EmpName='Anand'

Select * from Employees


