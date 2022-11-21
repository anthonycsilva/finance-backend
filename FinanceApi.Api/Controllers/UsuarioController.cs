using FinanceApi.Business.Interfaces.Services;
using FinanceApi.Business.ViewModels.Response;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;
    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet]
    public async Task<IEnumerable<UsuarioResponse>> ObterTodoUsuarios()
    {
        var result = await _usuarioService.ObterTodosOsUsuarios();
        return result;
    }
}
