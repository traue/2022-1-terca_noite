-- Nome do Banco: unilocadora_3noite


-- tabela de clientes
CREATE TABLE cliente(
    id_cliente INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    data_nasc DATE NOT NULL,
    cpf VARCHAR(11) NOT NULL UNIQUE
);

-- tabela de veículos
CREATE TABLE veiculo(
	placa VARCHAR(7) PRIMARY KEY,
    fabricante VARCHAR(30) NOT NULL,
    modelo VARCHAR(20) NOT NULL,
    ano INT NOT NULL,
    cor VARCHAR(20) NOT NULL
);

-- tabela de locações
CREATE TABLE locacao(
	nr_locacao INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    placa VARCHAR(7) NOT NULL,
    CONSTRAINT fk_locacao_veiculo FOREIGN KEY(placa) 
    	REFERENCES veiculo(placa),
    CONSTRAINT fk_locacao_cliente FOREIGN KEY(id_cliente) 
    	REFERENCES cliente(id_cliente)
);