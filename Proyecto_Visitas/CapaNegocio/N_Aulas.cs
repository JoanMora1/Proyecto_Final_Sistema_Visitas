using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class N_Aulas
    {
        D_Aulas d_Aulas = new D_Aulas();

        public void InsertandoAulas(E_Aulas e_Aulas)
        {
            d_Aulas.InsertarAula(e_Aulas);
        }

        public void Loadingcbx(ComboBox cbx)
        {
            d_Aulas.LoadCbx(cbx);
        }

        public void LoadingcbxAulas(ComboBox cbx, int listar)
        {
            d_Aulas.LoadcbxAulas(cbx, listar);
        }
    }
}
