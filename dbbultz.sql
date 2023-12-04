-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 30, 2023 at 03:12 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbbultz`
--

-- --------------------------------------------------------

--
-- Table structure for table `cardapio`
--

CREATE TABLE `cardapio` (
  `idItem` int(2) NOT NULL,
  `nomeItem` varchar(48) NOT NULL,
  `descItem` varchar(256) NOT NULL,
  `precoItem` decimal(4,2) NOT NULL,
  `tipoItem` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cardapio`
--

INSERT INTO `cardapio` (`idItem`, `nomeItem`, `descItem`, `precoItem`, `tipoItem`) VALUES
(1, 'Bultz Classic', 'Dois hamburgeres; Queijo; Alface; Molho Bultz; Cebola; Picles e um Pão com Gergelim.', 14.99, 1),
(2, 'GigaBultz', 'Pão de Brioche, Hamburger 300g, Alface Americana, Fatias de Tomate, Cebola Caramelizada, Fatias de Bacon e Queijo Cheddar.', 25.99, 1),
(3, 'Chicken Bultz', 'Só os frango.', 19.99, 1),
(4, 'Edison Legend', 'Hamburgão do Lendário Edison da Matta.', 54.00, 1),
(5, 'Castadelli Burger', 'Mítico Hamburgão em Homenagem ao Castadelli', 36.99, 1),
(6, 'Batata Frita - Pequena', 'Pequena Batatita', 7.99, 2),
(7, 'Batata Frita - Média', 'Mais ou menos :/', 11.00, 2),
(8, 'Batata Frita - Grande', 'Ai já aumentou a quantidade.', 14.00, 2),
(9, 'Batata Frita - Giga', 'Se comer sozinho explode.', 16.60, 2),
(10, 'Suco de Maracujá Natural', 'Suquin.', 6.00, 3),
(11, 'Suco de Laranja Natural', 'Essa peça que você queria?', 6.00, 3),
(12, 'Coca-Cola', 'Tsss.', 5.00, 3),
(13, 'Lopicos Burger', 'Lópicos de Álgebra Linear, Somente.', 26.97, 1);

-- --------------------------------------------------------

--
-- Table structure for table `cargos`
--

CREATE TABLE `cargos` (
  `cargoId` int(1) NOT NULL,
  `cargo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cargos`
--

INSERT INTO `cargos` (`cargoId`, `cargo`) VALUES
(1, 'Gerente'),
(2, 'Operador de Caixa');

-- --------------------------------------------------------

--
-- Table structure for table `comidas`
--

CREATE TABLE `comidas` (
  `tipoComida` int(1) NOT NULL,
  `nomeComida` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `comidas`
--

INSERT INTO `comidas` (`tipoComida`, `nomeComida`) VALUES
(0, 'Nenhum'),
(1, 'Lanche'),
(2, 'Acompanhamento'),
(3, 'Bebida');

-- --------------------------------------------------------

--
-- Table structure for table `funcionarios`
--

CREATE TABLE `funcionarios` (
  `cpf` varchar(14) NOT NULL,
  `nomeFunc` varchar(70) NOT NULL,
  `email` varchar(30) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `cargoId` int(2) NOT NULL,
  `fotoFunc` varchar(512) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `funcionarios`
--

INSERT INTO `funcionarios` (`cpf`, `nomeFunc`, `email`, `senha`, `cargoId`, `fotoFunc`) VALUES
('000.000.000-00', 'admin', 'admin@email.com', 'admin', 1, '');

-- --------------------------------------------------------

--
-- Table structure for table `pedidos`
--

CREATE TABLE `pedidos` (
  `idPedido` int(4) NOT NULL,
  `dataPed` date NOT NULL,
  `nomeCli` varchar(70) DEFAULT NULL,
  `cpfFunc` varchar(14) DEFAULT NULL,
  `precoFinal` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sangria`
--

CREATE TABLE `sangria` (
  `dataSangria` date NOT NULL,
  `valorTotal` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `venda`
--

CREATE TABLE `venda` (
  `idPedido` int(4) NOT NULL,
  `nomeLanche` varchar(32) NOT NULL,
  `qtdLanche` int(2) NOT NULL,
  `nomeAcomp` varchar(32) NOT NULL,
  `qtdAcomp` int(2) NOT NULL,
  `nomeBebida` varchar(32) NOT NULL,
  `qtdBebida` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cardapio`
--
ALTER TABLE `cardapio`
  ADD PRIMARY KEY (`idItem`),
  ADD KEY `FK_TipoItem` (`tipoItem`);

--
-- Indexes for table `cargos`
--
ALTER TABLE `cargos`
  ADD PRIMARY KEY (`cargoId`);

--
-- Indexes for table `comidas`
--
ALTER TABLE `comidas`
  ADD PRIMARY KEY (`tipoComida`);

--
-- Indexes for table `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`cpf`),
  ADD KEY `cargoId` (`cargoId`);

--
-- Indexes for table `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`idPedido`),
  ADD KEY `FK_FuncPed` (`cpfFunc`);

--
-- Indexes for table `venda`
--
ALTER TABLE `venda`
  ADD KEY `FK_idPedido` (`idPedido`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cardapio`
--
ALTER TABLE `cardapio`
  MODIFY `idItem` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `idPedido` int(4) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cardapio`
--
ALTER TABLE `cardapio`
  ADD CONSTRAINT `FK_TipoItem` FOREIGN KEY (`tipoItem`) REFERENCES `comidas` (`tipoComida`);

--
-- Constraints for table `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD CONSTRAINT `FK_CargoFunc` FOREIGN KEY (`cargoId`) REFERENCES `cargos` (`cargoId`);

--
-- Constraints for table `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `FK_FuncPed` FOREIGN KEY (`cpfFunc`) REFERENCES `funcionarios` (`cpf`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
