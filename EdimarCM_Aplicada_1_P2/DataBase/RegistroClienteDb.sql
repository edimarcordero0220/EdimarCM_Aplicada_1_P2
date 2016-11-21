use RegistroClienteDb;


Create table Clientes(
	ClienteId int identity (1,1) primary key,
	FechaNacimeinto datetime,
	LimiteCredito varchar(30)
);


create table TiposTelefono(
	TipoId  int identity (1,1) primary key,
	Descripcion varchar (30)

);

create table CientesTelefonos(
	id int identity(1,1) primary key,
	ClienteId int,
	TipoId int
);