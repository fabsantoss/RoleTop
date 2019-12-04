namespace RoleTopMVC.Models
{
    public class ServicosAdicionais : Evento
    {
        public ServicosAdicionais()
        {

        }
        public ServicosAdicionais(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}