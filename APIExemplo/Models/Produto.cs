using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Produto
    {
        public Produto() { }

        public Produto(string descricao, double preco, int qtdMin, string categoria, double tamanho, string cor)
        { 
            Descricao = descricao;
            Preco = preco;
            QtdMin = qtdMin;
            Categoria = categoria;
            Tamanho = tamanho;
            Cor = cor;
        }

        [Key]
        [JsonProperty("idProduto")]
        public int Id { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; } = null!;

        [JsonProperty("preco")]
        public double Preco { get; set; }

        [JsonProperty("qtdMin")]
        public int QtdMin { get; set; }

        [JsonProperty("categoria")]
        public string Categoria { get; set; } = null!;

        [JsonProperty("tamanho")]
        public double Tamanho { get; set; }

        [JsonProperty("cor")]
        public string Cor { get; set; } = null!;
    }
}
