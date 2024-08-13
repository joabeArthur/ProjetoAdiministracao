using LiteDB;

namespace LiteDBExample.Modelos;

public class Cliente : Registro
{
  [BsonId]

    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }
    public string Horario { get; set; }
    public string Salario { get; set; }
}