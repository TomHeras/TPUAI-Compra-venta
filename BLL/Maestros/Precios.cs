using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Maestros
{
    public class Precios
    {
        DAL.Maestros.Precios mapper = new DAL.Maestros.Precios();

        public string cargar_precios(BE.Maestros.Precios prec)
        {
            string fa;
            fa = mapper.alta(prec);

            return fa;
        }

        public string borrar_prec(BE.Maestros.Precios prec)
        {
            string fa;
            fa = mapper.baja(prec);

            return fa;
        }
        
        public string editar_precios(BE.Maestros.Precios prec)
        {
            string fa;
            fa = mapper.editarprecio(prec);

            return fa;
        }
    
            
        public List<BE.Maestros.Precios> Listar_precios()
        {
            List<BE.Maestros.Precios> precio = mapper.listaprecios();
            return precio;
        }

       public void aumento()
        {
            mapper.transaccion();
        }
    }
}
