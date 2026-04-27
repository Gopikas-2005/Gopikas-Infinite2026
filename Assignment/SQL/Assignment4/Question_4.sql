
begin 
declare @num int =5
declare @Fact int=1
declare @i int=@num
while @i>0
Begin
   set @Fact=@Fact*@i
  set  @i=@i-1
End

print @Fact
End
     
   Create or Alter Procedure MultiplicationTable 
   @num int
   As
   Begin
        Declare @i int =1
        Declare @Multiply int 
   
        While @i<=@num
        Begin
            Set @Multiply =@num*@i
            print Cast(@num As Varchar(10))+'X' +Cast(@i As Varchar(10)) +'='+Cast(@Multiply As Varchar(10))
            Set @i=@i+1

        End
   End
Exec MultiplicationTable 10

Create Database StudentDeatils
Create Table Students(Sid int Primary Key,Sname Varchar(100))
Create Table Marks(Mid int Primary Key,Sid int Foreign Key References Students(Sid),Score int )
Select * from Students
Select * from Marks

Insert into Students Values
(1 ,'Jack'),
(2 ,'Rithvik'),
(3 ,'Jaspreeth'),
(4 ,'Praveen'),
(5 ,'Bisa'),
(6 ,' Suraj')

Insert into Marks Values
(1,1,23),
(2, 6 ,95),
(3 ,4 ,98),
(4 ,2 ,17),
(5 ,3 ,53),
(6 ,5 ,13)
 
 Create or Alter Function Status(@num int)
 Returns Varchar(100)
 As 
 Begin
 Declare @Result Varchar(100)
    if Exists( Select Sname from Students  where Sid=(Select Sid from Marks Where Sid=@num and Score>=50))
    Begin
         Set @Result= 'Pass'
    End
    else
    Begin
         Set @Result= 'Fail'
    End
    Return @Result
 End

 Select  dbo.Status(6)



