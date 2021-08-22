CREATE DATABASE EmployeRecord;
create table tblEmploye
(EmployeeID nvarchar(20),
EmployeeName varchar(30),
Designation varchar(20),
Department varchar(30),
BasicSalary float ,

Scale int,
Rent float,
conveinceAllowance float ,
stationaryAllowance float ,
benevolentFund int,
incomeTax float,
SalaryMonth DATE,
TakeHomeSalary float,
EmployeePassword nvarchar(10),
constraint Employee_Pk primary key(EmployeeID));