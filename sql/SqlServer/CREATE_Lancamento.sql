CREATE TABLE Lancamento (
    id uniqueidentifier NOT NULL,
    tipoLancamento int NOT NULL,
    valor money NOT NULL,
	idContaCorrente uniqueidentifier NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (idContaCorrente) REFERENCES ContaCorrente(id)
);