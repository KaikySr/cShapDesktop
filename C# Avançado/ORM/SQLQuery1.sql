use master
go

if exists(select * from sys.databases where name = 'example')
    drop database example

create database example
go

use example
go

create table Cliente(
    ID int identity primary key,
    Nome varchar(100) not null,
    Senha varchar(100) not null,
    DataNasc date not null
);
go

select * from Cliente