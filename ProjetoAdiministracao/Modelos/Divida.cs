using LiteDBExample.Modelos;
using LiteDB;

namespace LiteDBExample.Modelos;

public class Divida : Registro
{
  [BsonId]

    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Data { get; set; }
    public string Valor { get; set; }
}