CRIA O BANCO DE DADOS DEPOIS FAZ A CONEXÃO

-- apagar banco de dados
drop database dbLoja;
 
-- criando o banco de dados
create database dbLoja;
 
-- acessando banco de dados
use dbLoja;
 
-- criando as tabelas
create table tbFuncionarios(
codFunc int not null auto_increment,
nome varchar(100),
email varchar(100),
cpf varchar(14),
telCel char(10),
endereco varchar(100),
numero int,
cep int,
bairro varchar (100),
cidade varchar (100),
estado varchar (100),
primary key(codFunc));

também criar os usuarios:

create table tbUsuarios( codUsu int not null AUTO_INCREMENT, nome varchar(30) not null, senha varchar(10) not null, PRIMARY KEY (codUsu));
