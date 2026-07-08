class Combate
{
    public Heroi heroi;

    public Monstro monstro;

    public Combate(Heroi heroi, Monstro monstro)
    {
        this.heroi = heroi;

        this.monstro = monstro;
    }

        // Fight

    public void Iniciar()
    {
        heroi.Atacar(monstro);

        monstro.Atacar(heroi);

        Console.WriteLine($"Vida do Herói: {heroi.vida}");

        Console.WriteLine($"Vida do Monstro: {monstro.vida}");
    }

};
