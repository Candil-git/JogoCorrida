namespace JogoCorrida
{
    public class Jogo
    {
        public Elemento Carro { get; set; }
        public List<Elemento> Obstaculos { get; set; }
        public int Velociade { get; set; }
        public int Pontuacao { get; set; }
        public int PontuacaoMax { get; set; }
        public int Tempo { get; set; }
        public int ColisoesPermitidas { get; set; }
        public int Faixa1Inicio { get; set; }
        public int Faixa1Fim { get; set; }
        public int Faixa2Inicio { get; set; }
        public int Faixa2Fim { get; set; }
        public int YMax { get; set; } = 50;
        public Elemento Galao{ get; set; }

        // MÉTODOS
        public void IniciarJogo()
        {
            Carro = new Elemento();
            Carro.Tipo = TipoElemento.Carro;
            Carro.PosicaoX = PosicionaObjeto(1);
            Carro.PosicaoY = YMax - 150;

            Obstaculos = FabricaObstaculos(3, 120, 250);
            CriarGalao();
        }

        public List<Elemento> FabricaObstaculos(int qtd, int dmin, int dmax)
        {
            var y_inicial = 0;
            var rnd = new Random();
            var obstaculos = new List<Elemento>();

            for (int i = 0; i < qtd; i++)
            {
                if (i != 0)
                    y_inicial -= rnd.Next(dmin, dmax);
                var ob = new Elemento
                {
                    Tipo = TipoElemento.Obstaculo
                };

                var faixa = rnd.Next(1, 3);
                ob.PosicaoX = PosicionaObjeto(faixa);
                ob.PosicaoY = y_inicial;
                obstaculos.Add(ob);
            }

            return obstaculos;
        }

        public int PosicionaObjeto(int faixa)
        {
            if (faixa == 1)
            {
                return Faixa1Inicio + (Faixa1Fim - Faixa1Inicio) / 2;
            }
            else
            {
                return Faixa2Inicio + (Faixa2Fim - Faixa2Inicio) / 2;
            }
        }

        public void Acelerar(int incremento)
        {
            Velociade += incremento;
        }

        private int ChecaFaixaElemento(Elemento elemento)
        {
            if (elemento.PosicaoX >= Faixa1Inicio && elemento.PosicaoX <= Faixa1Fim){
                return 1;
            }else{
                return 2;
            }
        }

        public bool ChecarColisao()
        {
            foreach (var ob in Obstaculos)
            {
                if (ChecaFaixaElemento(Carro) == ChecaFaixaElemento(ob)){
                    if(Math.Abs(Carro.PosicaoY - ob.PosicaoY) <= 10)
                        return true;
                    }
                }
            return false;
        }

        public bool VerificarFimJogo()
        {
            return false;
        }



        public void MovimentaObstaculos()
        {
            foreach(var ob in Obstaculos)
            {
                ob.PosicaoY += 10;

                if(ob.PosicaoY > YMax)
                {
                    Pontuacao += 10;
                    var rnd = new Random();
                    ob.PosicaoY = -rnd.Next(60, 200); 
                    int novaFaixa = rnd.Next(1, 3);
                    ob.PosicaoX = PosicionaObjeto(novaFaixa);
                    
                }
            }
        }

        public void CriarGalao()
        {
            var rnd = new Random();
            int faixa = rnd.Next(1, 3);

            Galao = new Elemento
            {
                Tipo = TipoElemento.Galao,
                PosicaoX = PosicionaObjeto(faixa),
                PosicaoY = -100 
            };
        }

        public void MovimentaMoeda()
        {
            if (Galao != null)
            {
                Galao.PosicaoY += 10;

                // Se a moeda saiu da tela por baixo sem ser coletada, reseta ela lá no topo
                if (Galao.PosicaoY > YMax)
                {
                    ResetarGalao();
                }
            }
        }

        public bool ChecarColetaGalao()
        {
            if (Galao != null)
            {
                // Se estiver na mesma faixa e próximo na vertical (Y)
                if (ChecaFaixaElemento(Carro) == ChecaFaixaElemento(Galao))
                {
                    if (Math.Abs(Carro.PosicaoY - Galao.PosicaoY) <= 15)
                    {
                        return true; // Coletou!
                    }
                }
            }
            return false;
        }

        public void ResetarGalao()
        {
            var rnd = new Random();
            int faixa = rnd.Next(1, 3);
            Galao.PosicaoX = PosicionaObjeto(faixa);
            Galao.PosicaoY = -rnd.Next(200, 500); // Surge com um atraso aleatório
        }
    }
}
