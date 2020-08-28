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

SELECT * FROM produto WHERE precoProduto<>0 ORDER BY idProduto DESC limit 3;

create table produto(
idProduto int not null auto_increment primary key,
fotoProduto varchar(255) not null,
nomeProduto varchar(255) not null,
precoProduto decimal(10,2) not null,
categoriaProduto varchar(255) not null,
promocaoProduto decimal(10,2)
);





create table curtidos(
idCurtido int not null auto_increment primary key,
idProduto int not null,
idUsuario int not null,
constraint fk_idProduto foreign key (idProduto) references produto(idProduto),
constraint fk_idUsuario foreign key (idUsuario) references usuario(idUsuario)
);

create table carrinho(
idCarrinho int not null auto_increment primary key,
idProdutos int not null,
idUsuarios int not null,
constraint fk_idProdutos foreign key (idProdutos) references produto(idProduto),
constraint fk_idUsuarios foreign key (idUsuarios) references usuario(idUsuario)
);

insert into curtidos(idProduto,idUsuario) values(1,1);

select*from produto inner join curtidos on produto.idProduto=curtidos.idProduto where idUsuario=1; 

insert into usuario(nomeUsuario,emailUsuario,senhaUsuario,nascimentoUsuario,telefoneUsuario,tipoUsuario) values ("adm","a@mail.com","1234","01-01-0001","12345678","1")
