using System;
using System.Windows.Forms;
using cad_vendedorN;

namespace CadastroProdutosMercado
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
