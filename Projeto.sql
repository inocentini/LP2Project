CREATE DATABASE AULA;
USE AULA;
CREATE TABLE Pessoa(cpf varchar(14), nome varchar(64), email varchar(32), telefone varchar(15),PRIMARY KEY(cpf));

CREATE TABLE Login(nome varchar(16), senha varchar(256),PRIMARY KEY(nome));
/*Falta adicionar a foreign key para ligar com pessoa*/

CREATE TABLE Conta(id int auto_increment, nome varchar(64), detalhes varchar(128), valor float, vencimento date, cpfresponsavel varchar(14),primary key(id),foreign key(cpfresponsavel) references pessoa(cpf));