namespace API.Core.Domain
{
    public class Usuario : Base
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
