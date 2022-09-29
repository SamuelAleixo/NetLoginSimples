using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NetLoginSimples.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AplicacaosUser class
public class AplicacaoUser : IdentityUser
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
}
