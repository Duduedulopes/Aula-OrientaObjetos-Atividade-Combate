class Heroi
{
    public string nome {get;set;}

    public int vida {get;set;}

    public int atacar {get;set;}


    // Atacar o Monstro

        public void Atacar(Monstro monstro)
    {
        monstro.vida -= atacar;
        Console.WriteLine($"{nome} atacou {monstro.nome} causando {atacar} de dano");

    }

};