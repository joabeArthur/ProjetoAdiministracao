using LiteDB;
using LiteDBExample.Modelos;

namespace ProjetoAdiministracao;

public class BaseControle
{
  CadastroFuncionarios cf;

  //----------------------------------------------------------------------------

  protected string NomeDaTabela;
  protected static LiteDatabase liteDB = null;

  //----------------------------------------------------------------------------

  public BaseControle()
  {
    var pathToPersonalFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SESI.db");

    if (liteDB == null)
      liteDB = new LiteDatabase(@"filename=" + pathToPersonalFolder + "; upgrade=true; Mode=Exclusive");
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Registro r)
  {
    
  }
  
  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
  }
  
  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual List<Registro>? LerTodos()
  {
    return null;
  }

  //----------------------------------------------------------------------------
}

internal class cf
{
}