using System;

class Disciplina
{
    public string NomeDisciplina { get; set; }
    public int CargaHoraria { get; set; }

    public Disciplina(string nome, int cargaHoraria)
    {
        NomeDisciplina = nome;
        CargaHoraria = cargaHoraria;
    }
}