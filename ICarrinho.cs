namespace Interface
{
    public interface ICarrinho
    {
         void Ler();

         void Cadastrar(Produto produto);

         void Alterar(int _codigo, Produto produto);

         void Deletar(Produto produto);

         void MostrarTotal();
    }
}