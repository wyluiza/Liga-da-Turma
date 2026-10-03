public class Festival
{
    string nomeFestival = "";
    string localFestival = "";
    string dataFestival = "";
    string horarioFestival = "";

    public string Nome
    {
        get
        {
            return nomeFestival;
        }
    }
    public string Local
    {
        get
        {
            return localFestival;
        }
    }
    public string Data
    {
        get
        {
            return dataFestival;
        }
    }
    public string Horario
    {
        get
        {
            return horarioFestival;
        }
    }
    public Festival(string nome, string local, string data, string horario)
    {
        nomeFestival = nome;
        localFestival = local;
        dataFestival = data;
        horarioFestival = horario;
    }
}