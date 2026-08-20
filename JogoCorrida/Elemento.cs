namespace JogoCorrida
{
    //Classe Elemento
    public class Elemento
    {
        //Propriedades dos Elementos
        public TipoElemento Tipo { get; set; }
        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }

        //Metodo para movimentar os Elementos
        public void Movimentar(int x, int y)
        {
            PosicaoX = x; PosicaoY = y;
        }
    }
}