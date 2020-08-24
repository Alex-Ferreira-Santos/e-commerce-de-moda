create database moda;
use moda;

create table usuario(
idUsuario int not null auto_increment primary key,
nomeUsuario varchar(255) not null,
emailUsuario varchar(255) not null,
senhaUsuario varchar(255) not null,
nascimentoUsuario varchar(255) not null,
telefoneUsuario int not null,
tipoUsuario int not null
);

create table produto(
idProduto int not null auto_increment primary key,
fotoProduto varchar(255) not null,
nomeProduto varchar(255) not null,
precoProduto decimal not null,
categoriaProduto varchar(255) not null,
promocaoProduto decimal,
idUsuario int,
constraint fk_idUsuario foreign key (idUsuario) references usuario(idUsuario)

);



insert into usuario(nomeUsuario,emailUsuario,senhaUsuario,nascimentoUsuario,telefoneUsuario,tipoUsuario) values ("adm","a@mail.com","1234","01/01/0001","12345678","1")
