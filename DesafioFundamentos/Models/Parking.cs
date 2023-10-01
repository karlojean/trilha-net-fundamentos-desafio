namespace DesafioFundamentos.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal hourlyPrice = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal hourlyPrice)
        {
            this.initialPrice = initialPrice;
            this.hourlyPrice = hourlyPrice;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string plate = Console.ReadLine();
            this.vehicles.Add(plate);
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string plate = Console.ReadLine();

            // Verifica se o veículo existe
            if (vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int hours = Convert.ToInt32(Console.ReadLine());
                decimal totalValue = initialPrice + hourlyPrice * hours; 

                vehicles.Remove(plate);

                Console.WriteLine($"O veículo {plate} foi removido e o preço total foi de: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListVehicles()
        {            if (vehicles.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach(string vehicle in vehicles){
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
