using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apRefCruz
{
  public partial class FrmRefCruzada : Form
  {
    public FrmRefCruzada()
    {
      InitializeComponent();
    }

    ListaSimples<Referencia> referencias;

    private void FrmRefCruzada_Load(object sender, EventArgs e)
    {
      referencias = new ListaSimples<Referencia>();
    }

    private void btnProcessar_Click(object sender, EventArgs e)
    {
      // pedir nome do arquivo a ser processado, usando o dlgAbrir
      // ler cada linha do arquivo separadamente
      // separar palavra por palavra da linha lida
      // verificar se essa palavra já existe na lista referencias
      // se não existir, incluí-la em ordem e o número da linha em que foi encontrada
      // se existir, incluir apenas a linha em que ela está no fim da lista Linhas
      // do nó dessa palavra
      // ao final do arquivo:
      // percorrer a lista ligada referencias sequencialmente
      //    listar a palavrea de cada nó
      //    listar os números de linha de cada palavra
      //    avançar para a palavra seguinte

    }
  }
}
