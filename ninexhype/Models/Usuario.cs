using Microsoft.AspNetCore.Identity;

namespace ninexhype.Models;

public class Usuario : IdentityUser
{
    public string Foto { get; set; }

    public string Nome { get; set; }

    public int DataNascimento { get; set; }
}
