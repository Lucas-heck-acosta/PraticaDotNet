using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    internal class Carro
    {
        [JsonPropertyName("marca")]
        public string? Marca { get; set; }

        [JsonPropertyName("modelo")]
        public string? Modelo { get; set; }

        [JsonPropertyName("ano")]
        public int Ano { get; set; }

        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        [JsonPropertyName("motor")]
        public string? Motor { get; set; }

        [JsonPropertyName("transmissao")]
        public string? Transmissao { get; set; }

        public void ExibirDetalhesDoCarro()
        {
            Console.WriteLine("\n==============");
            Console.WriteLine($"{Marca} - {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Motor: {Motor} - Cambio: {Transmissao}");
            Console.WriteLine($"Carroceria: {Tipo}\n");
        }
    }
}
