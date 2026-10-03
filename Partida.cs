    public abstract class Partida // tornei ela uma classe abstrata pra usar de modelo
{
    Equipe equipe1;
    Equipe equipe2;
    Modalidade modalidade;

    int placarEquipe1 = 0;
    int placarEquipe2 = 0;

    public Partida(Equipe equipe1, Equipe equipe2, Modalidade modalidade)
    {
        this.equipe1 = equipe1; //o this serve para indicar que estamos falando de um campo que pertence ao próprio objeto.
        this.equipe2 = equipe2;
        this.modalidade = modalidade;
    }
        public abstract void RegistrarPlacar(int pontosEquipe1, int pontosEquipe2);
        protected void DefinirPlacar(int pontosEquipe1, int pontosEquipe2) // protected define qm vai acessar o método
        {
            placarEquipe1 = pontosEquipe1;
            placarEquipe2 = pontosEquipe2;
        }
    public int PlacarEquipe1
    {
        get
        {
            return placarEquipe1;
        }
    }
    public int PlacarEquipe2
    {
        get
        {
            return placarEquipe2;
        }
    }
    public Equipe Equipe1
{
    get
    {
        return equipe1;
    }
}
    public Equipe Equipe2
    {
        get
        {
            return equipe2;
        }
    }
    public Modalidade Modalidade
    {
        get
        {
            return modalidade;
        }
    }
    public abstract string ObterResultado();
}