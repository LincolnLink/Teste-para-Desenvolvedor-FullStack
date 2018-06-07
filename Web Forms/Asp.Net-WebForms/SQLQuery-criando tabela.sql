
create table Computador(
	IdComputador integer identity(1,1),
	Marca nvarchar(50) not null,
	Modelo nvarchar(50) not null,
	PlacaMae nvarchar(50) not null,
	Mram integer not null,
	Hd integer not null,
	HdMarca nvarchar(50) not null,
	Vprocessador nvarchar(50) not null,
	Foto nvarchar(50) not null,
	IdUsuario integer not null,
	primary key(IdComputador),
	foreign key(IdUsuario) references Usuario(IdUsuario))
go