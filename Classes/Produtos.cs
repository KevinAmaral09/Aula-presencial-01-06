namespace ExemploLista.Classes
{
    public class Produtos
    {

        public int Codigo { get; set;}

        public string Nome { get; set;}

        public float Preco { get; set;}

        public Produtos(){
            

        }

        public Produtos(int _Codigo,string _Nome, float _Preco)
        {
            this.Codigo = Codigo;
            this.Nome = _Nome;
            this.Preco = _Preco;

        }


    }
}