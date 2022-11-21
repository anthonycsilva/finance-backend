using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApi.Business.Entities;

namespace FinanceApi.Business.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> AdicionarUsuario(Usuario entity);
        Task<bool> RemoverUsuario(Usuario entity);
        Task<Usuario> AlterarUsuario(Usuario entity);
        Task<List<Usuario>> ObterTodosOsUsuarios();
    }
}