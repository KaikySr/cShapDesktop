use master
go

if exists(select * from sys.databases where name = 'MyCamparidit')
	drop database MyCamparidit

create database MyCamparidit
go

use MyCamparidit
go

create table usuario
(
	Id int identity primary key,
	Usuario varchar(100) not null,
	Email varchar(100) not null,
	Senha varchar(100) not null,
	DataNasc date not null,
	Foto varchar(255)
);
GO

select * from usuario

create table forum
(
	Id int identity primary key,
	Nome varchar(100) not null,
	Descricao varchar(255),
	DataCriado datetime default current_timestamp
);
GO
create table post
(
	Id int identity primary key,
	IdCriador int not null,
	IdForum int not null,
	Likes int,
	Conteudo varchar(255),
	Foto varchar(255),
	DataCriado datetime default current_timestamp
	foreign key (IdCriador) references usuario(Id),
	foreign key (IdForum) references forum(Id)
)
GO
create table cargos
(
	Id int identity primary key,
	Nome varchar(100) not null,
	IdUsuario int not null,
	IdForum int not null,
	foreign key (IdUsuario) references usuario(Id),
	foreign key (IdForum) references forum(Id)
)
GO
create table permissoes
(
	Id int identity primary key,
	VerPost int,
	Postar int,
	DarLike int,
	DarDeslike int,
	RemoverPost int,
	RemoverMembros int,
	EditarPosts int,
	PromoverMembros int,
	CriarEditarCargos int,
	DeletarForum int
)
GO
create table CargosXpermissoes
(
	Id int identity primary key,
	IdCargo int not null,
	IdPermissoes int not null,
	foreign key (IdCargo) references cargos(Id),
	foreign key (IdPermissoes) references permissoes(Id)
)
GO

insert into usuario values (
	'bananasLegais',
	'kaikysr2004@gmail.com',
	'peixessaolegais',
	'02/02/2003',
	''
)
GO

select * from dbo.forum

insert into forum values (
	'losdabasyh',
	'nesse forum valentoes fodem',
	null
)
GO

insert into post values (
	1,
	1,
	0,
	'gatinhos feios merecem amor e não devem ser chutados',
	'',
	null
)
GO
