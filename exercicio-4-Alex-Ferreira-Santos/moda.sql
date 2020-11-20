-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 20-Nov-2020 às 19:00
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `moda`
--
CREATE DATABASE moda;
-- --------------------------------------------------------

--
-- Estrutura da tabela `carrinho`
--

CREATE TABLE `carrinho` (
  `idCarrinho` int(11) NOT NULL,
  `idProdutos` int(11) NOT NULL,
  `idUsuarios` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `carrinho`
--

INSERT INTO `carrinho` (`idCarrinho`, `idProdutos`, `idUsuarios`) VALUES
(11, 5, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `curtidos`
--

CREATE TABLE `curtidos` (
  `idCurtido` int(11) NOT NULL,
  `idProduto` int(11) NOT NULL,
  `idUsuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `curtidos`
--

INSERT INTO `curtidos` (`idCurtido`, `idProduto`, `idUsuario`) VALUES
(22, 5, 1),
(23, 5, 1),
(24, 5, 1),
(25, 5, 1),
(26, 5, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `idProduto` int(11) NOT NULL,
  `fotoProduto` varchar(255) NOT NULL,
  `nomeProduto` varchar(255) NOT NULL,
  `precoProduto` decimal(10,2) NOT NULL,
  `categoriaProduto` varchar(255) NOT NULL,
  `promocaoProduto` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`idProduto`, `fotoProduto`, `nomeProduto`, `precoProduto`, `categoriaProduto`, `promocaoProduto`) VALUES
(1, 'https://images.lojanike.com.br/1024x1024/produto/98083_1564048_20190730175641.png', 'Tênis nike', '105.50', 'calcados', '100.00'),
(2, 'https://upload.wikimedia.org/wikipedia/commons/6/69/Blusa.png', 'blusa azul', '99.99', 'feminino', '0.00'),
(4, 'https://www.ciainfantil.com.br/166-tm_thickbox_default/bermuda-tactel-estampa.jpg', 'Bermuda Infantil Tactel Estampa', '75.00', 'infantil', '0.00'),
(5, 'https://images.lojanike.com.br/1024x1024/produto/180479_1822830_20191119125824.png', 'Tênis Nike Air Tailwind 79 Masculino', '150.00', 'calcados', '100.00'),
(7, 'https://www.ciainfantil.com.br/258-tm_thickbox_default/camiseta-infantil-bolso-jacares.jpg', ' CIA Infantil Camiseta Infantil Bolso Jacarés', '70.00', 'infantil', '45.00'),
(8, 'https://www.ciainfantil.com.br/603-tm_thickbox_default/bermuda-infantil-sarja-azul-bolsos.jpg', 'Bermuda Infantil Sarja Azul com Bolsos', '60.00', 'infantil', '0.00'),
(9, 'https://static-store.worldticket.com.br/store/images/423/29423.png', 'Camiseta Masculina - Lanterna Verde', '80.00', 'masculino', '0.00'),
(10, 'https://a1.vnda.com.br/saintstudio/2019/07/26/1797-bermuda-chino-2663.png?1564162822', 'Bermuda Chino Preta', '170.00', 'masculino', '0.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `nomeUsuario` varchar(255) NOT NULL,
  `emailUsuario` varchar(255) NOT NULL,
  `senhaUsuario` varchar(255) NOT NULL,
  `nascimentoUsuario` varchar(255) NOT NULL,
  `telefoneUsuario` int(11) NOT NULL,
  `tipoUsuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `nomeUsuario`, `emailUsuario`, `senhaUsuario`, `nascimentoUsuario`, `telefoneUsuario`, `tipoUsuario`) VALUES
(1, 'adm', 'a@mail.com', '1234', '01-01-0001', 12345678, 1),
(2, 'aline', 'b@gmail.com', '5678', '2020-08-30', 87654321, 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD PRIMARY KEY (`idCarrinho`),
  ADD KEY `fk_idProdutos` (`idProdutos`),
  ADD KEY `fk_idUsuarios` (`idUsuarios`);

--
-- Índices para tabela `curtidos`
--
ALTER TABLE `curtidos`
  ADD PRIMARY KEY (`idCurtido`),
  ADD KEY `fk_idProduto` (`idProduto`),
  ADD KEY `fk_idUsuario` (`idUsuario`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`idProduto`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `carrinho`
--
ALTER TABLE `carrinho`
  MODIFY `idCarrinho` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `curtidos`
--
ALTER TABLE `curtidos`
  MODIFY `idCurtido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `idProduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD CONSTRAINT `fk_idProdutos` FOREIGN KEY (`idProdutos`) REFERENCES `produto` (`idProduto`),
  ADD CONSTRAINT `fk_idUsuarios` FOREIGN KEY (`idUsuarios`) REFERENCES `usuario` (`idUsuario`);

--
-- Limitadores para a tabela `curtidos`
--
ALTER TABLE `curtidos`
  ADD CONSTRAINT `fk_idProduto` FOREIGN KEY (`idProduto`) REFERENCES `produto` (`idProduto`),
  ADD CONSTRAINT `fk_idUsuario` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
