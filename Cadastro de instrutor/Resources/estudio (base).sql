-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19-Ago-2019 às 18:36
-- Versão do servidor: 10.3.16-MariaDB
-- versão do PHP: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `estudio`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `exercicio`
--

CREATE TABLE `exercicio` (
  `observacoes_ex` varchar(15) NOT NULL,
  `foto_exercicio` tinyblob NOT NULL,
  `id_exercicio` varchar(10) NOT NULL,
  `descricao_exercicio` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `ficha_evolução`
--

CREATE TABLE `ficha_evolução` (
  `observações` varchar(40) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `id_fichaev` varchar(11) NOT NULL,
  `data_avaliação` date NOT NULL,
  `id_exercicio` varchar(10) NOT NULL,
  `id_usuario` varchar(15) NOT NULL,
  `ev_clinica` varchar(20) NOT NULL,
  `diag_clinico` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `ficha_paciente`
--

CREATE TABLE `ficha_paciente` (
  `cpf` varchar(11) NOT NULL,
  `id_ficha` varchar(11) NOT NULL,
  `obs_posturais` varchar(20) NOT NULL,
  `objetivo` varchar(20) NOT NULL,
  `inicio_tratamento` date NOT NULL,
  `fim_tratamento` date NOT NULL,
  `queixa_principal` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `paciente`
--

CREATE TABLE `paciente` (
  `endereço` int(11) NOT NULL,
  `email` int(11) NOT NULL,
  `telefone` int(11) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `sexo` tinyint(1) NOT NULL,
  `nome` varchar(10) NOT NULL,
  `ocupação` varchar(10) NOT NULL,
  `data_nasc` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `nome_usuario` varchar(10) NOT NULL,
  `sobre_usu` varchar(10) NOT NULL,
  `id_usuario` varchar(11) NOT NULL,
  `nomedeusu` char(12) NOT NULL,
  `senha_usuario` char(15) NOT NULL,
  `senha_usuario2` char(15) NOT NULL,
  `tipo_usuario` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `exercicio`
--
ALTER TABLE `exercicio`
  ADD PRIMARY KEY (`id_exercicio`);

--
-- Índices para tabela `ficha_evolução`
--
ALTER TABLE `ficha_evolução`
  ADD PRIMARY KEY (`id_fichaev`(10));

--
-- Índices para tabela `ficha_paciente`
--
ALTER TABLE `ficha_paciente`
  ADD PRIMARY KEY (`id_ficha`);

--
-- Índices para tabela `paciente`
--
ALTER TABLE `paciente`
  ADD PRIMARY KEY (`cpf`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
