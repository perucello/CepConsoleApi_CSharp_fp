using System;
using System.Threading.Tasks;
using Refit;

namespace CepConsoleApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                string cepBuscar = "13171090";
                var cepClient = RestService.For<ApiService>("https://viacep.com.br/");
                //Console.WriteLine("Informe o cep: ");

                //string cepBuscar = Console.ReadLine().ToString();
                Console.WriteLine("Consultando " + cepBuscar);

                var address = await cepClient.GetAddressAsync(cepBuscar);

                Console.WriteLine(
                    $"\nLogradouro: {address.Logradouro }, " +
                    $"\nBairro: {address.Bairro}, " +
                    $"\nCidade: {address.Localidade}," +
                    $"\nGia: {address.Gia}"
                    );

                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine("Falha de Exception " + e.Message);
            }
        }
    }
}
