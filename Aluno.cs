using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Media { get; set; }
    public int Faltas { get; set; }
    public string Status { get; set; }
    public bool IsSemestreFinalizado { get; set; }
    public Disciplina DisciplinaCursada { get; set; }

    public Aluno(string nome, bool semestreFinalizado, Disciplina disciplinaCursada)
    {
        Nome = nome;
        Status = "cursando";
        IsSemestreFinalizado = semestreFinalizado;
        DisciplinaCursada = disciplinaCursada;
    }

    public double AtribuirNota1(double nota)
    {
        Nota1 = nota;
        return Nota1;
    }

    public double AtribuirNota2(double nota)
    {
        Nota2 = nota;
        return Nota2;
    }

    public void CalcularMedia()
    {
        Media = (Nota1 + Nota2) / 2;
    }

    public void AtribuirFalta()
    {
        Faltas++;
    }

    public void AbonarFalta()
    {
        if (Faltas > 0)
        {
            Faltas--;
        }
    }

    public string VerificarStatus(Disciplina disciplina)
    {
        if (IsSemestreFinalizado)
        {
            double limiteFaltas = disciplina.CargaHoraria * 0.25;

            if (Media >= 7 && Faltas <= limiteFaltas)
            {
                Status = "aprovado";
            }
            else
            {
                Status = "reprovado";
            }
            Console.WriteLine("O aluno " + Nome + " está " + Status + " na disciplina " + disciplina.NomeDisciplina);
        }
        else
        {
            Status = "cursando";
            Console.WriteLine("O aluno " + Nome + " ainda está " + Status + " a disciplina " + disciplina.NomeDisciplina + " e portanto não pode ser avaliado.");
        }



        return Status;
    }
}
