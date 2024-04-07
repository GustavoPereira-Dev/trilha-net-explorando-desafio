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
          if (hospedes.Count <= Suite.Capacidade)
          {
              Hospedes = hospedes;
          }
          else
          {
              throw new InvalidOperationException("Capacidade insuficiente para acomodar todos os hóspedes.");
          }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
          return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
          decimal valorDiaria = DiasReservados * Suite.ValorDiaria;

          if (DiasReservados >= 10)
          {
              valorDiaria *= 0.9m; // Aplica desconto de 10%
          }

          return valorDiaria;
        }
    }
}
