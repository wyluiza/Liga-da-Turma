public class PartidaEsports : Partida, InterfaceResultadoPartida // "herda" as características da classe Partida.
{
    public PartidaEsports(Equipe equipe1, Equipe equipe2) 
        : base(equipe1, equipe2, Modalidade.Esports) // chama o construtor da classe principal e define
    {
        
    }
    public override void RegistrarPlacar(int pontosEquipe1, int pontosEquipe2)
    {
        if (pontosEquipe1 < 0 || pontosEquipe2 < 0 || pontosEquipe1 > 2 || pontosEquipe2 > 2 || pontosEquipe1 == pontosEquipe2 || (pontosEquipe1 < 2 && pontosEquipe2 < 2))
        {
            
            throw new ArgumentException("Placar inválido para uma série melhor de três mapas.");
        }

        DefinirPlacar(pontosEquipe1, pontosEquipe2);
    }
    public override string ObterResultado() // override pq estamos sobrescrevendo o método da classe base
{
    if (PlacarEquipe1 > PlacarEquipe2)
    {
        return $"Vitória de {Equipe1.Nome}";
    }
    else
    {
        return $"Vitória de {Equipe2.Nome}";
    }
}
}