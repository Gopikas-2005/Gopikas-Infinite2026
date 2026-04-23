Create  Database EmpDept;
Create Table EmployeeDetails(empno int Primary Key, ename Varchar(20), job Varchar(20), mgr_id int, 
hiredate Date, sal Decimal, comm Decimal, deptno int) 
 Create Table Department(deptno int , dname Varchar(20), loc varchar(20));

 Insert into EmployeeDetails(empno, ename, job, mgr_id, hiredate, sal, comm, deptno) Values
(7369, 'SMITH',  'CLERK',    7902, '1980-12-17',  800,  NULL, 20),
(7499, 'ALLEN',  'SALESMAN', 7698, '1981-02-20', 1600,   300, 30),
(7521, 'WARD',   'SALESMAN', 7698, '1981-02-22', 1250,   500, 30),
(7566, 'JONES',  'MANAGER',  7839, '1981-04-02', 2975,  NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250,  1400, 30),
(7698, 'BLAKE',  'MANAGER',  7839, '1981-05-01', 2850,  NULL, 30),
(7782, 'CLARK',  'MANAGER',  7839, '1981-06-09', 2450,  NULL, 10),
(7788, 'SCOTT',  'ANALYST',  7566, '1987-04-19', 3000,  NULL, 20),
(7839, 'KING',   'PRESIDENT',NULL, '1981-11-17', 5000,  NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500,     0, 30),
(7876, 'ADAMS',  'CLERK',    7788, '1987-05-23', 1100,  NULL, 20),
(7900, 'JAMES',  'CLERK',    7698, '1981-12-03',  950,  NULL, 30),
(7902, 'FORD',   'ANALYST',  7566, '1981-12-03', 3000,  NULL, 20),
(7934, 'MILLER', 'CLERK',    7782, '1982-01-23', 1300,  NULL, 10);

Insert into Department(deptno, dname, loc) Values
(10   ,'ACCOUNTING','NEW YORK' ),
(20  ,'RESEARCH','DALLAS' ),
(30   ,'SALES','CHICAGO' ),
(40   ,'OPERATIONS','BOSTON' )

Select * from EmployeeDetails where ename Like 'a%';

Select * from EmployeeDetails where mgr_id  is null;

Select empno,ename,sal from EmployeeDetails where sal between 1200 and 1400;

Select e.empno, e.ename, e.sal AS Before_Salary from EmployeeDetails e JOIN Department d ON e.deptno = d.deptno WHERE d.dname = 'Research';
Update e
Set sal = sal * 1.10
From EmployeeDetails e
JOIN Department d On e.deptno = d.deptno
Where  d.dname = 'Research';

Select e.*
from  EmployeeDetails e
JOIN Department d On e.deptno = d.deptno
Where d.dname = 'Research';

Select Count(*) AS Total_Clerks
From EmployeeDetails
Where job = 'Clerk';



Select job, Avg(sal) AS Avg_Salary, Count(*) AS Employee_Count
From EmployeeDetails
Group by job;

Select * from EmployeeDetails where Sal =(Select min(sal) from EmployeeDetails) or  Sal= (Select max(Sal) from EmployeeDetails)

Select * from Department where Deptno not in (Select Deptno from EmployeeDetails);

Select ename, sal
From EmployeeDetails
Where job = 'Analyst'
  AND sal > 1200
  AND deptno = 20
Order By ename Asc;

Select d.deptno, d.dname, Sum(e.sal) As Total_Salary
From Department d
LEFT JOIN EmployeeDetails e On d.deptno = e.deptno
Group By d.deptno, d.dname;

Select ename ,sal from EmployeeDetails where ename='Miller' or ename='Smith';

Select * from EmployeeDetails where ename Like'a%' or ename Like'm%';

Select ename, sal * 12 As Yearly_Salary
From EmployeeDetails
Where ename = 'Smith';

Select ename,sal from EmployeeDetails where Sal not Between 1500 and 2850;

Select mgr_id, Count(*) As Number_of_Employees
from EmployeeDetails
Where mgr_id IS NOT NULL
Group By mgr_id
Having Count(*) > 2;
