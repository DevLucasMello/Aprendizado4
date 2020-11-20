Create database RhDb
Default character set utf8
Default collate utf8_general_ci;

use RhDb;

create table Funcionario(
RE int(5) not null primary key,
nome varchar(50) not null,
senha varchar(12) not null,
diasSemana int(2) not null,
horarioTrabalhoEntrada time not null,
horarioTrabalhoSaida time not null
)default charset = utf8;

create table Atividade(
codAtividade bigint not null auto_increment primary key,
RE int(5) not null,
nome varchar(50) not null,
dtInicio date not null,
hrInicio time not null,
hrFim time not null,
semana varchar(4) not null,
ativ text not null
)default charset = utf8;

describe Funcionario;
describe Atividade;

select * from Funcionario;
select * from Atividade;

SELECT dtInicio,hrInicio,hrFim FROM Atividade WHERE dtInicio like "2020-07%" and RE=719;

drop table Funcionario;
drop table Atividade;

/*create table Livro(
codLivro int not null auto_increment primary key,
titulo varchar(45) not null,
autor varchar(45) not null,
genero varchar(45) not null,
valorEstoque double not null,
quantidadeEstoque bigint not null
)default charset = utf8;

create table Reserva(
codReserva int not null auto_increment primary key,
descricao varchar(45) not null,
foreign key (codReserva) references Livro(codLivro)
)default charset = utf8;

create table Cliente_tem_Livro(
id int not null auto_increment primary key,
Cliente_CPFouCNPJ bigint(11),
Livro_codLivro int,
foreign key (Cliente_CPFouCNPJ) references Cliente(CPFouCNPJ),
foreign key (Livro_codLivro) references Livro(codLivro)
)default charset = utf8;

describe Cliente;
describe Livro;
describe Reserva;
describe Cliente_tem_Livro;

select * from Cliente;
select * from Livro;
select * from Reserva;
select * from Cliente_tem_Livro;

drop database Livraria;*/