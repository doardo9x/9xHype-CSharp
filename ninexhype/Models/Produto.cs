using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ninexhype.Models;

[Table("produto")]
public class Produto
{
    public int Id { get; set; }

    //Ligar tipo de produtos a Produto
    public TipoProduto GeneroProduto { get; set; }

    public string Nome { get; set; }

    public int Preco { get; set; }

    public string Descricao { get; set; }

    public string Foto { get; set; }
    
    public int Tamanho { get; set; }
}
