using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SeuSaldoDoDiaEmDolar
{
    class Program
    {
        private const string ApiKey = "FVR2OQQ9VKXJWQYP";
        private const string ApiUrl = "https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency=BRL&to_currency=USD&apikey=" + ApiKey;

        static async Task Main(string[] args)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    Console.WriteLine("Enviando requisição para a API...");
                    HttpResponseMessage response = await client.GetAsync(ApiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Resposta da API recebida.");
                    Console.WriteLine(responseBody);

                    JObject json = JObject.Parse(responseBody);

                    if (json["Realtime Currency Exchange Rate"] != null && json["Realtime Currency Exchange Rate"]["5. Exchange Rate"] != null)
                    {
                        string exchangeRate = json["Realtime Currency Exchange Rate"]["5. Exchange Rate"].ToString();
                        Console.WriteLine($"Cotação do dólar hoje: 1 BRL = {exchangeRate} USD");

                        Console.Write("Digite o valor em Reais (BRL): ");
                        string input = Console.ReadLine();
                        if (decimal.TryParse(input, out decimal reais))
                        {
                            decimal dolares = reais * decimal.Parse(exchangeRate);
                            Console.WriteLine($"{reais} BRL = {dolares} USD");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro ao obter a taxa de câmbio.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
