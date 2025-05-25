using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaNegocio.CN_Categorias;
using CapaDatos;

namespace CapaNegocio
{
    class CN_Categorias
    {
        public class CN_Categoria
        {
            private CD_Categorias objetoCD = new CD_Categorias();

            public DataTable MostrarCategorias()
            {
                return objetoCD.MostrarCategorias();
            }





        }


    }
}
