namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            try
            {
                bool verificaCapacitade = hospedes.Count <= Suite.Capacidade;

                if (verificaCapacitade)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    Console.WriteLine($"ERRO: O número de hóspedes ultrapassa a capacidade máxima da Suíte");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exeção. {ex.Message}");
            }
            
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            // *IMPLEMENTE AQUI*

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;

            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                decimal valorDesconto = valorTotal * 0.10M;
                valorTotal = valorTotal - valorDesconto;
                return valorTotal;
            }
            else
            {
                return valorTotal;
            }

           
        }
    }
}