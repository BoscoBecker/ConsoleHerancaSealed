namespace ConsoleHerancaSealed.Accounts
{
    class Account{

        public int Agencia { get; set; }
        public int Conta {  get; set; }
        public string? Titular { get; set; }
        public double CurrentBalance { get; set; }

        public Account() { }

        public Account(int agencia, int conta, string? titular, double currentBalance)
        {
            Agencia = agencia;
            Conta = conta;
            Titular = titular;
            CurrentBalance = currentBalance;
        }        
    }
}
