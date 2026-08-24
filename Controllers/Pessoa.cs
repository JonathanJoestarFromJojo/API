using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PessoaController : ControllerBase
{
    [HttpPost("calcular-imc")]
    public IActionResult CalcularIMC(string nome, float peso, float altura)
    {
        float imc = peso / (altura * altura);
        return Ok(new { Nome = nome, IMC = imc });
    }

    [HttpGet("consulta-tabela-imc")]
    public IActionResult ConsultaTabelaIMC(float imc)
    {
        string classificacao;
        if (imc < 18.5) classificacao = "Abaixo do peso";
        else if (imc < 24.9) classificacao = "Peso normal";
        else if (imc < 29.9) classificacao = "Sobrepeso";
        else classificacao = "Obesidade";

        return Ok(new { IMC = imc, Classificacao = classificacao });
    }
}
