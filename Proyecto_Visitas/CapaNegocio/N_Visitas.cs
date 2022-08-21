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
    public class N_Visitas
    {
        D_Visitas d_Visitas = new D_Visitas();
        
        public void InsertandoVisitas(E_Visitas e_Visitas)
        {
            d_Visitas.InsertarVisitas(e_Visitas);
        }

        public List<E_Visitas> ListarVisita(string buscar)
        {
            return d_Visitas.ListarVisitas(buscar);
        }

        public void InsertandoEdificio(E_Visitas e_Visitas, E_Aulas e_Aulas)
        {
            d_Visitas.InsertarEdificio(e_Visitas, e_Aulas);
        }

        public void EditandoEdificio(E_Visitas e_Visitas, E_Aulas e_Aulas)
        {
            d_Visitas.EditarEdificio(e_Visitas, e_Aulas);
        }

        public void Loadingcbx(ComboBox cbx)
        {
            d_Visitas.Loadcbx(cbx);
        }
    }
}
