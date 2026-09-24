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
}