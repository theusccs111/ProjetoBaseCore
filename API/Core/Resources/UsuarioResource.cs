using API.Core.Domain;

namespace API.Core.Resources
{
    public class UsuarioResource : Base
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public static class UsuarioMapper
        {
            public static UsuarioResource ModelToResource(Usuario usuario)
            {
                var usuarioResource = new UsuarioResource()
                {
                    Login = usuario.Login,
                    Senha = usuario.Senha,

                    Id = usuario.Id,
                    IsAtivo = usuario.IsAtivo,
                    CriadoPor = usuario.CriadoPor
                };
                return usuarioResource;
            }

            public static Usuario ResourceToModel(UsuarioResource usuarioResource, Usuario usuario)
            {

                usuario.Login = usuarioResource.Login;
                usuario.Senha = usuarioResource.Senha;

                usuario.Id = (usuario.Id > 0) ? usuario.Id : usuarioResource.Id;
                usuario.IsAtivo = usuarioResource.IsAtivo;
                usuario.CriadoPor = usuarioResource.CriadoPor > 0 ? usuarioResource.CriadoPor : usuario.CriadoPor;

                return usuario;
            }
        }

    }
}