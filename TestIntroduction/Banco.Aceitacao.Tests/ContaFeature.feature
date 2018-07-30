Funcionalidade: Conta Corrente
	Uma conta corrente passando por diversas
	operacoes e validando seus comportamentos

@TesteAceitacaoContaCorrente

Cenário: Deposito em conta
	Dado que uma conta esteja ativa
	E que esteja sem saldo
	Quando For realizado o deposito de um valor
			| Valor |
			| 500   |
	Então O saldo disponivel deve o mesmo que o depositado
			| SaldoDisponivel |
			| 500             |	
