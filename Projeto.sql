CREATE DATABASE AULA;
USE AULA;
CREATE TABLE Pessoa(cpf varchar(14), nome varchar(64), email varchar(32), telefone varchar(15),PRIMARY KEY(cpf));

CREATE TABLE Login(nome varchar(16), senha varchar(256),PRIMARY KEY(nome));
/*Falta adicionar a foreign key para ligar com pessoa*/
