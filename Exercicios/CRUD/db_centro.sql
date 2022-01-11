-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Jan-2022 às 02:57
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_centro`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso`
--

CREATE TABLE `curso` (
  `id_curso` int(11) NOT NULL,
  `nome` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `curso`
--

INSERT INTO `curso` (`id_curso`, `nome`) VALUES
(1, 'Design Gráfico'),
(2, 'Programação Java'),
(3, 'Programação JavaScript'),
(4, 'Programação C#'),
(5, 'Redes de Computadores'),
(6, 'Hardware');

-- --------------------------------------------------------

--
-- Estrutura da tabela `formador`
--

CREATE TABLE `formador` (
  `id` int(11) NOT NULL,
  `nome` varchar(60) DEFAULT NULL,
  `curso` int(11) DEFAULT NULL,
  `morada` varchar(120) NOT NULL,
  `telefone` varchar(12) DEFAULT NULL,
  `email` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `formador`
--

INSERT INTO `formador` (`id`, `nome`, `curso`, `morada`, `telefone`, `email`) VALUES
(1, 'Emerlinda José', 1, 'Cazenga - Marco Histórico', '928-382-938', 'Ermelianjosé283@gmail.com'),
(2, 'Emerlinda Jos', 1, 'Cazenga - Marco Históricod', '928-382-9384', 'Ermelianjosé283@gmdail.com'),
(3, 'Geraldo Antunes', 2, 'Luanda - Marçal', '992-838-293', 'gantunes@gmail.com'),
(4, 'Marcelino Gregório ', 6, 'Benguela', '992-830-920', 'djagregorio@hotmail.com'),
(5, 'Auguso', 1, 'dkjfa', '928-328-017', 'dakdljfjak'),
(6, 'Anderson Mario', 5, 'dkjfa', '938-438-979', 'djadjl@fjaljkldf');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `curso`
--
ALTER TABLE `curso`
  ADD PRIMARY KEY (`id_curso`);

--
-- Índices para tabela `formador`
--
ALTER TABLE `formador`
  ADD PRIMARY KEY (`id`),
  ADD KEY `curso` (`curso`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `curso`
--
ALTER TABLE `curso`
  MODIFY `id_curso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `formador`
--
ALTER TABLE `formador`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `formador`
--
ALTER TABLE `formador`
  ADD CONSTRAINT `formador_ibfk_1` FOREIGN KEY (`curso`) REFERENCES `curso` (`id_curso`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
