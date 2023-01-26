create database Bank;
use Bank;
create table Client 
(Client_Id varchar(10) primary key, Client_Name varchar(30), Client_Address
varchar(30), Client_DOB date, Client_Age int, Client_TP int);
insert into Client values
('C1','Gayan', 'Galle', '1988-11-22', 31, 0772569014);
insert into Client values
('C2', 'Pathum', 'Matara', '1990-12-22', 28, 0712569014);
insert into Client values
('C3',
'Supun'
, 'Kandy', '1992-10-15', 26, 0765569014);
insert into Client values
('C4', 'Sunil', 'Colombo', '1995-08-02', 25, 0782569078);

select * from Client;