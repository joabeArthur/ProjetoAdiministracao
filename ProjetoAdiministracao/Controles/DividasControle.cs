using LiteDB;
using LiteDBExample.Modelos;

namespace ProjetoAdiministracao;

public class DividasControle : BaseControle
{
  //----------------------------------------------------------------------------

  public DividasControle() : base()
  {
    NomeDaTabela = "Divida";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idDivida)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idDivida);
  }

//----------------------------------------------------------------------------

  public virtual List<Divida>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Divida>(NomeDaTabela);
    return new List<Divida>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idDivida)
  {
    var collection = liteDB.GetCollection<Divida>(NomeDaTabela);
    collection.Delete(idDivida);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Divida divida)
  {
    var collection = liteDB.GetCollection<Divida>(NomeDaTabela);
    collection.Upsert(divida);
  }

  //----------------------------------------------------------------------------
}