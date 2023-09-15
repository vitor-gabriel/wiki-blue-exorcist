using System.Text;
using Microsoft.AspNetCore.Mvc;
using wiki_blue_exorcist.Models;

namespace wiki_blue_exorcist.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase {

    [HttpGet]
    public async Task<Home> Get() {
        Home home = new()
        {
            Title = "Blue Exorcist",
            Sinopse = "Rin Okumura e seu irmão Yukio são dois adolescentes criados por um pai adotivo chamado Shiro Fujimoto," + 
            "um dos maiores exorcistas do mundo. Quando Rin descobre que possuí forças paranormais e que é filho de um dos demônios mais fortes do mundo. Seu pai, Shiro Fujimoto, precisa se sacrificar para proteger sua família dos demônios." +
            "Com a intenção de vingar a morte de Shiro Fujimoto, Rin deseja se tornar um exorcista. Mas para isso acontecer ele precisa participar de um curso de exorcista especial, que poucas pessoas conhecem.",
            ImageLocation = "https://cdn.wallpapersafari.com/14/38/C0Vp8Y.jpg",
        };
        return await Task.FromResult(home);
    }
}