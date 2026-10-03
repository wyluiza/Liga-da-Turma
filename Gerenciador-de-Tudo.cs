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
        public Partida CadastrarPartida(Equipe equipe1, Equipe equipe2, Modalidade modalidade, int pontosEquipe1, int pontosEquipe2)
        {
        Partida novaPartida;
        if (modalidade == Modalidade.Futsal)
            {
                novaPartida = new PartidaFutsal(equipe1, equipe2);
            }
            else
            {
                novaPartida = new PartidaEsports(equipe1, equipe2);
            }
        novaPartida.RegistrarPlacar(pontosEquipe1, pontosEquipe2);
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