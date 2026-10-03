public class Gerenciador
{
    List<Equipe> equipes = new ();

    public void CadastrarEquipe(string nome)
    {
        Equipe novaEquipe = new Equipe(nome);
        equipes.Add(novaEquipe);
    }
    public List<Equipe> ConsultarEquipes()
    {
        return equipes;
    }

    List<Partida> partidas = new ();
        public Partida CadastrarPartida(Equipe equipe1, Equipe equipe2, Modalidade modalidade)
    {
        Partida novaPartida = new Partida(equipe1, equipe2, modalidade);
        partidas.Add(novaPartida);
        return novaPartida;
    }
    public List<Partida> ConsultarPartidas()
    {
        return partidas;
    }
    Festival? festival;
    public void CadastrarFestival(string nome, string local, string data, string horario)
    {
        Festival novoFestival = new Festival(nome, local, data, horario);
        festival = novoFestival;
    }
    public Festival? ConsultarFestival() //esse ? faz retornar null caso n tenha nenhum festival
    {
        return festival;
    }

}