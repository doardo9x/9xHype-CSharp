using System.ComponentModel.DataAnnotations.Schema;

namespace ninexhype.Models;

[Table("marca")]
public class Marca
{
    
    public int Id { get; set; }

    public string Nome { get; set; }

    //Ligar produtos a Marca
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }
}
