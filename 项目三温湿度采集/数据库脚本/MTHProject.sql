Use master
go
if exists(select*from sysdatabases where name='MultiTHMonitorDB')
drop database MultiTHMonitorDB
go
create database MultiThMonitorDB
on primary
(
	name='MultiTHMonitorDB',
	filename='D:\SQLserverDB\SQLDB\MultiTHMonitorDB',
	size=100MB,
	filegrowth=50MB
)
log on
(
	name='MultiTHMonitorDB_log',
	filename='D:\SQLserverDB\SQLDB\MultiTHMonitorDB_log.ldf',
	size=100MB,
	filegrowth=50MB
)
go

use MultiThMonitorDB
--<<创建用户表>>
if exists(select*from sysobjects where name='SysAdmin')
drop table SysAdmin
go
create table SysAdmin
(
	LoginId int identity(10000,1) primary key,--用户id
	LoginName varchar(50) not null,
	LoginPwd varchar(20) not null,
	ParamSet bit not null,
	Recipe bit not null,
	HistoryLog bit not null,
	HistoryTrend bit not null,
	UserMange bit not null
)
go

insert into SysAdmin(LoginName,LoginPwd,ParamSet,Recipe,HistoryLog,HistoryTrend,UserMange) values('Admin','123',1,1,1,1,1)

Select * from SysAdmin

if exists (select *from sysobjects where name='SysLog')
drop table SysLog
go
create table SysLog
(
	Id int identity(1,1) primary key,
	InsertTime varchar(50) not null,
	Note varchar(20) not null,
	AlarmType varchar(20) not null,
	Operator varchar(20) not null,
	VarName varchar(20) not null
)
go

if exists (select* from sysobjects where name= 'ActualData')
drop table ActualData
go
create table ActualData
(
	Id int identity(1,1) primary key,
	InsertTime varchar(50) not null,
	Station1Temp varchar(20) not null,
	Station1Humidity varchar(20) not null,
	Station2Temp varchar(20) not null,
	Station2Humidity varchar(20) not null,
	Station3Temp varchar(20) not null,
	Station3Humidity varchar(20) not null,
	Station4Temp varchar(20) not null,
	Station4Humidity varchar(20) not null,
	Station5Temp varchar(20) not null,
	Station5Humidity varchar(20) not null,
	Station6Temp varchar(20) not null,
	Station6Humidity varchar(20) not null,
)