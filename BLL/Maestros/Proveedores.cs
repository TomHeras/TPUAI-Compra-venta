using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Maestros
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b
    public class Proveedores
    {
        DAL.Maestros.Proveedores mapper = new DAL.Maestros.Proveedores();

<<<<<<< HEAD
=======
=======
   public class Proveedores
    {
        DAL.Maestros.Proveedores mapper = new DAL.Maestros.Proveedores();
        
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b

        public string altaprov(BE.Maestros.Proveedores prov)
        {
            string fa;
            fa = mapper.agregar(prov);
            return fa;
        }

        public List<BE.Maestros.Proveedores> listrarprovs()
        {
            List<BE.Maestros.Proveedores> prov = mapper.listar();
            return prov;
<<<<<<< HEAD
        }
=======
<<<<<<< HEAD
        }
=======
        } 
>>>>>>> b6f6eb6522076e877aedbb1cd33213bc145936f8
>>>>>>> 1f4b423563f794f30b19a98afdd3824efffd224b

        public string editarprov(BE.Maestros.Proveedores prov)
        {
            string fa;
            fa = mapper.editarprov(prov);
            return fa;
        }

        public string bajaprov(BE.Maestros.Proveedores prov)
        {
            string fa;
            fa = mapper.BajaProv(prov);
            return fa;

        }

        public string AsginarProd(BE.Maestros.Proveedores pro)
        {
            string fa = mapper.Asignar(pro);
            return fa;
        }

        public void serealizar()
        {
            mapper.XML();
        }
    }
}
