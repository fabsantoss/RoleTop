namespace RoleTopMVC.Models
{
    public class ServicosAdicionais : Produto
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