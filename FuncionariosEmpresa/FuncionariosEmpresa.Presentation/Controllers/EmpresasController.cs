using FuncionariosEmpresa.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FuncionariosEmpresa.Presentation.Controllers;

[Route("api/empresas")]
[ApiController]
public class EmpresasController : ControllerBase
{
    private readonly IServiceManager _service;

    public EmpresasController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult ObterEmpresas()
    {
        try
        {
            var empresas = _service.EmpresaService.ObterTodasEmpresas(rastrearAlteracoes: false);

            return Ok(empresas);
        }
        catch
        {
            return StatusCode(500, "Erro Interno do Servidor");
        }
    }
}