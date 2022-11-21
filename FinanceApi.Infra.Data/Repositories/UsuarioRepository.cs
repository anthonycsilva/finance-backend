using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApi.Business.Entities;
using FinanceApi.Business.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FinanceApi.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _dataContext;
        public UsuarioRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Task<Usuario> AdicionarUsuario(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> AlterarUsuario(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Usuario>> ObterTodosOsUsuarios()
        {
            var usuarios = await _dataContext.Usuarios.ToListAsync();
            return usuarios;
        }

        public Task<bool> RemoverUsuario(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}