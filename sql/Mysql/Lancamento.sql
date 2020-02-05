USE TesteDBServer;

CREATE TABLE Lancamento (
	id varchar(36) PRIMARY KEY,
	tipoLancamento int NOT NULL,
    valor decimal(15,2) NOT NULL,
    idContaCorrente varchar(36) NOT NULL,
    FOREIGN KEY (idContaCorrente)
        REFERENCES ContaCorrente(id)
)