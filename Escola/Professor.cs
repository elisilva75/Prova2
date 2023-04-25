using Escola;
// Classe Professor, que herda de Pessoa
public class Professor : Pessoa
{
    private List<Disciplina> disciplinas = new List<Disciplina>();

    public List<Disciplina> Disciplinas
    {
        get { return disciplinas; }
        set { disciplinas = value; }
    }

    public override string ToString()
    {
        string disciplinasStr = "";
        foreach (Disciplina disciplina in Disciplinas)
        {
            disciplinasStr += disciplina.Nome + ", ";
        }
        disciplinasStr = disciplinasStr.Substring(0, disciplinasStr.Length - 2);

        return $"Professor: {Nome} - Disciplinas: {disciplinasStr}";
    }
}