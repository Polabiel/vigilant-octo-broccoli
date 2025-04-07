using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apRefCruz
{
  public class Referencia : IComparable<Referencia>, IRegistro
  {
    string palavra;
    ListaSimples<Linha> linhas;

    public Referencia(string palavra, int linha)
    {
      this.palavra = palavra;
      this.linhas.InserirAposFim(new Linha(linha));
    }

    public int CompareTo(Referencia outraReferencia)
    {
      return this.palavra.CompareTo(outraReferencia.palavra);
    }

    public string FormatoDeArquivo()
    { return this.palavra; }
  }
}
