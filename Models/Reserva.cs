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
           
                if (Suite.Capacidade >= hospedes.Count())
                {
                    Hospedes = hospedes;
                    Console.WriteLine("Hospedes cadastrados com sucesso.");
                }
                else
                {
                    // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                    // *IMPLEMENTE AQUI*
                    throw new Exception("Numero de hospedes exede o permetido");
                }
            
                     
           
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            
                // TODO: Retorna o valor da diária               
                // Cálculo: DiasReservados X Suite.ValorDiaria
                // *IMPLEMENTE AQUI*

                decimal valor = DiasReservados * Suite.ValorDiaria;

                // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
                // *IMPLEMENTE AQUI*
                if (DiasReservados >= 10)
                {
                    decimal desconto = valor * 0.10m;                 
                    valor = valor - desconto;
                   
                }

                return valor;
            
            
        }
    }
}