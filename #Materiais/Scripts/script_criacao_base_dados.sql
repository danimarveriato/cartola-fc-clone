/* Criação da base*/
CREATE DATABASE cartola_fc;

/* Setando o banco a ser utilizado*/
USE cartola_fc;

/*Criação das tabelas*/
CREATE TABLE time (
    codigo INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(80) NOT NULL,
    logomarca VARCHAR(50),
    estado VARCHAR(80),
    cidade VARCHAR(80),
    status BIT DEFAULT 1
);


CREATE TABLE jogador (
    codigo INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(80) NOT NULL,
    apelido VARCHAR(50),
    ind_estrangeiro BIT,
    data_nascimento date,
    altura decimal(2,2),
    peso decimal(2,2),
    posicao_origem INT NOT NULL,
    status BIT DEFAULT 1,
    cod_time INT NOT NULL,
    data_cadastro date default now(),
    FOREIGN KEY (cod_time) REFERENCES time (codigo)
);


CREATE TABLE usuario (
    codigo INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(80) NOT NULL,
    apelido VARCHAR(50),
    email VARCHAR(80) NOT NULL,
    senha VARCHAR(50) NOT NULL,
    data_nascimento date,
    cidade VARCHAR(50),
    cod_time_coracao INT,
    ind_administrador BIT NOT NULL,
    FOREIGN KEY (cod_time_coracao) REFERENCES time (codigo)
);


CREATE TABLE time_cartoleiro (
    codigo INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    codigo_cartoleiro INT NOT NULL,
    nome_time VARCHAR(80) NOT NULL,
    cod_goleiro INT,
    cod_zagueiro_1 INT,
    cod_zagueiro_2 INT,
    cod_lateral_1 INT,
    cod_lateral_2 INT,
    cod_meio_1 INT,
    cod_meio_2 INT,
    cod_meio_3 INT,
    cod_atacante_1 INT,
    cod_atacante_2 INT,
    cod_atacante_3 INT,
    ind_time_escalado BIT DEFAULT 0,
		FOREIGN KEY (codigo_cartoleiro) REFERENCES usuario(codigo)
);

--Inserindo dados
INSERT INTO time (nome, logomarca, estado, cidade) VALUES
('América-MG', NULL, 'MG', 'Belo Horizonte'),
('Athletico-PR', NULL, 'PR', 'Curitiba'),
('Atlético-MG', NULL, 'MG', 'Belo Horizonte'),
('Bahia', NULL, 'BH', 'Salvador'),
('Botafogo', NULL, 'SP', 'Ribeirão Preto'),
('Corinthians', NULL, 'SP', 'São Paulo'),
('Coritiba', NULL, 'PR', 'Curitiba'),
('Cruzeiro', NULL, 'MG', 'Belo Horizonte'),
('Cuiabá', NULL, 'MT', 'Cuiabá'),
('Flamengo', NULL, 'RJ', 'Rio de Janeiro'),
('Fluminense', NULL, 'RJ', 'Rio de Janeiro'),
('Fortaleza', NULL, 'CE', 'Fortaleza'),
('Goiás', NULL, 'GO', 'Goiânia'),
('Grêmio', NULL, 'RS', 'Porto Alegre'),
('Internacional', NULL, 'RS', 'Porto Alegre'),
('Palmeiras', NULL, 'SP', 'São Paulo'),
('Bragantino', NULL, 'SP', 'São Paulo'),
('Santos', NULL, 'SP', 'São Paulo'),
('São Paulo', NULL, 'SP', 'São Paulo'),
('Vasco da Gama', NULL, 'RJ', 'Rio de Janeiro');

--Inserindo usuário ADMIN
INSERT INTO usuario (nome, apelido, email, senha, cod_time_coracao, ind_administrador) 
VALUES ('ADMIN', 'ADMIN', 'admin@cartola.com.br', md5('12345'), null, 1);