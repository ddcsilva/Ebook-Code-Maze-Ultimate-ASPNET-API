using FuncionariosEmpresa.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FuncionariosEmpresa.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInformativo("Aqui está uma mensagem informativa dos valores da Controller.");
        _logger.LogDepuracao("Aqui está uma mensagem de depuração dos valores da Controller.");
        _logger.LogAdvertencia("Aqui está uma mensagem de advertência dos valores da Controller.");
        _logger.LogErro("Aqui está uma mensagem de erro dos valores da Controller.");

        return new string[] { "valor1", "valor2" };
    }
}