using LiteDB;
using LiteDBExample.Modelos;

namespace ProjetoAdiministracao;

public class AReceberControle : BaseControle
{
  //---------------------------------------------------------------------------
  public AReceberControle() : base()
  {
    NomeDaTabela = "AReceber";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idAReceber)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idAReceber);
  }

//----------------------------------------------------------------------------

  public virtual List<AReceber>? LerTodos()
  {
    var tabela = liteDB.GetCollection<AReceber>(NomeDaTabela);
    return new List<AReceber>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idAReceber)
  {
    var collection = liteDB.GetCollection<AReceber>(NomeDaTabela);
    collection.Delete(idAReceber);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(AReceber receber)
  {
    var collection = liteDB.GetCollection<AReceber>(NomeDaTabela);
    collection.Upsert(receber);
  }

  //----------------------------------------------------------------------------
}