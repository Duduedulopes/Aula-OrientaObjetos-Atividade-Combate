class Program
{
    static void Main(string[] args)
    {
        Heroi meuHeroi = new Heroi { nome = "Eduardo", vida = 100, atacar = 20 };
        Monstro meuMonstro = new Monstro { nome = "Esposa", vida = 100, atacar = 15 };

        Combate batalha = new Combate(meuHeroi, meuMonstro);

        // Fight
        batalha.Iniciar();
    }
};