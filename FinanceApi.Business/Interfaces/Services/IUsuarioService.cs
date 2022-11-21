using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApi.Business.ViewModels.Request;
using FinanceApi.Business.ViewModels.Response;

namespace FinanceApi.Business.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioResponse> AdicionarUsuario(UsuarioRequest viewModel);
        Task<bool> RemoverUsuario(UsuarioRequest viewModel);
        Task<UsuarioResponse> AlterarUsuario(UsuarioRequest viewModel);
        Task<List<UsuarioResponse>> ObterTodosOsUsuarios();
    }
}