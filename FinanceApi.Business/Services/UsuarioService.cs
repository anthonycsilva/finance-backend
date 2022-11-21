using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FinanceApi.Business.Interfaces.Repositories;
using FinanceApi.Business.Interfaces.Services;
using FinanceApi.Business.ViewModels.Request;
using FinanceApi.Business.ViewModels.Response;

namespace FinanceApi.Business.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;

        }
        public Task<UsuarioResponse> AdicionarUsuario(UsuarioRequest viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponse> AlterarUsuario(UsuarioRequest viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UsuarioResponse>> ObterTodosOsUsuarios()
        {
            var usuarios = await _usuarioRepository.ObterTodosOsUsuarios();
            var usuariosReponse = _mapper.Map<List<UsuarioResponse>>(usuarios);
            return usuariosReponse;
        }

        public Task<bool> RemoverUsuario(UsuarioRequest viewModel)
        {
            throw new NotImplementedException();
        }
    }
}