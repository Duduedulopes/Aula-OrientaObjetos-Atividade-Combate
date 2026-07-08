class Monstro
{
    public string nome {get;set;}

    public int vida {get;set;}

    public int atacar {get;set;}

    // Atacar o Heroi

    public void Atacar(Heroi heroi)
{
    heroi.vida -= atacar;
    Console.WriteLine($"{nome} atacou {heroi.nome} causando {atacar} de dano");
}

};