[ApiController]
[Route("api/[controller]")]
public class FreteController : ControllerBase
{
    [HttpPost("calcular")]
    public IActionResult CalcularFrete([FromBody] Produto produto)
    {
        float volume = produto.Altura * produto.Largura * produto.Comprimento;
        float taxaVolume = volume * 0.01f;

        float taxaEstado = produto.UF switch
        {
            "SP" => 50.0f,
            "RJ" => 60.0f,
            "MG" => 55.0f,
            _ => 70.0f
        };

        float valorFrete = taxaVolume + taxaEstado;

        return Ok(new { produto.Nome, Volume = volume, ValorFrete = valorFrete });
    }
}

public class Produto
{
    public string Nome { get; set; }
    public float Peso { get; set; }
    public float Altura { get; set; }
    public float Largura { get; set; }
    public float Comprimento { get; set; }
    public string UF { get; set; }
}
