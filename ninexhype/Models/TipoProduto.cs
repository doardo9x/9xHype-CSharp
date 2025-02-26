using System.ComponentModel.DataAnnotations.Schema;

namespace ninexhype.Models;

[Table("TipoProduto")]
public class TipoProduto
{
    public int Id { get; set; }

    //Tenis, calça, roupa, blusa etc
    public string GeneroProduto { get; set; }
}
