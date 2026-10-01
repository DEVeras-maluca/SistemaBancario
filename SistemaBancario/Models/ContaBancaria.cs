namespace SistemaBancario.Models
{
    // CLASSE ABSTRATA - NÃO PODE SER INSTÂNCIADA, SOMENTE HERDADA (PROTEGE OS DADOS, NÃO PODENDEOSER ACESSADA DIRETAMENTE)
    public abstract class ContaBancaria
    {
        private string _numeroConta;
        private decimal _saldo;

        // ENCAPSULAMENTO: PROTEGE CAMPOS PRIVADOS E OS ACESSA COM MÉTODOS PÚBLICOS (GET/SET)

        public string NumeroConta
        {
            get => _numeroConta;
            protected set
            {
                _numeroConta = value;
            }

        }

        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }

        public string NomeTitular { get; set; }

        public List<string> ExtratoTransacoes { get; set; } = new List<string>();

        // PROTECTED: SOMENTE CLASSES FILHAS ACESSAM
        // CONSTRUTOR SERÁ CHAMADO SEMPRE

        protected ContaBancaria(string numeroConta, decimal saldoInicial, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta CRIADA com saldo de: R$ {saldoInicial:F2}");
        }

        // POLIMORFISMO/MÉTODO VIRTUAL: QUANDO UM MESMO MÉTODO EXECUTA AÇÕES DIFERENTES (É POSSÍVEL SACAR DE VÁRIAS FORMAS DIFERENTES)

        public virtual void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                ExtratoTransacoes.Add($"Depósito + R${valor:F2} | Saldo Atual: R$ {Saldo:F2}");
            }
        }

        // MÉTODO ABSTRATO: OBRIGA SUA CLASSES FILHAS A DETERMINAR SUAS PRÓPRIAS PARTICULARIDADES DE SAQUE

    }
}
