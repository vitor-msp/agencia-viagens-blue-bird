create database AgenciaViagens;
go
use AgenciaViagens;
go
create table Cliente (
  id_cli int identity(1,1),
  nome nvarchar(50) not null,
  rg varchar(10) not null,
  cpf char(11) not null,
  dt_nasc date not null,
  email varchar(30) not null,
  constraint pk_cli primary key (id_cli)
);
go
create table Destino (
  id_dest int identity(1,1),
  cidade nvarchar(30) not null,
  uf char(2) not null,
  loc_desemb nvarchar(30) not null,
  constraint pk_dest primary key (id_dest)
);
go
create table Promocao (
  id_promo int identity(1,1),
  destino int,
  desconto decimal(3,2) not null,
  vencimento datetime not null,
  constraint pk_promo primary key (id_promo),
  constraint fk_promo_dest foreign key (destino) references Destino (id_dest),
);
go
create table Viagem (
  id_viag int identity(1,1),
  destino int not null,
  partida smalldatetime not null,
  chegada smalldatetime not null,
  vlr_padrao decimal(7,2) not null,
  constraint pk_viag primary key (id_viag),
  constraint fk_viag_dest foreign key (destino) references Destino (id_dest)
);
go
create table Adquire (
  id_adq int identity(1,1),
  cliente int not null,
  viagem int not null,
  promocao int,
  constraint pk_adq primary key (id_adq),
  constraint fk_adq_cli foreign key (cliente) references Cliente (id_cli),
  constraint fk_adq_viag foreign key (viagem) references Viagem (id_viag),
  constraint fk_adq_promo foreign key (promocao) references Promocao (id_promo)
);
go
