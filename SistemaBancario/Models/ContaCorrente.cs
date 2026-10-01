namespace SistemaBancario.Models
{
    // HERANÇA: CONTA CORRENTE HERDA O QUE JÁ FOI ESTABELECIDO EM CONTABANCARIA
    public class ContaCorrente : ContaBancaria
    {
        // CHAMANDO CONSTRUTOR DA CLASSE BASE E PASSANDO PARÂMETROS

        public ContaCorrente(string numeroConta, decimal saldoInicial, string nomeTitular) : base(numeroConta, saldoInicial, nomeTitular)
        {
        }

        // PERMITE SAQUE CASO CONTA POSSUA SALDO SUFICIENTE
        public override bool Sacar(decimal valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                ExtratoTransacoes.Add($"Saque: -R${valor:F2} | Saldo Atual: R${Saldo:F2}");
                return true;
            }
            return false;
        }

        // FUNCIONALIDADE DE INVESTIMENTO PARA OS CLIENTES, NÃO É OBRIGATÓRIA

        public void Investir(decimal valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                decimal rendimento = valor * 1.05m; // Simula investimento com 5% de retorno imediato
                Saldo += rendimento;
                ExtratoTransacoes.Add($"Investimento Aplicado: R$ {valor:F2} (Rendeu para R$ {rendimento:F2}) | Saldo Atual: R$ {Saldo:F2}");
            }
        }
    }
}
