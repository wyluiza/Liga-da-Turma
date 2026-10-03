public class PartidaFutsal : Partida // meio que herda as características da classe Partida.
{
    public PartidaFutsal(Equipe equipe1, Equipe equipe2) 
        : base(equipe1, equipe2, Modalidade.Futsal) // chama o construtor da classe principal e define a modalidade
    {
        
    }
    
    public override void RegistrarPlacar(int pontosEquipe1, int pontosEquipe2)
    {
        DefinirPlacar(pontosEquipe1, pontosEquipe2);
    }
}