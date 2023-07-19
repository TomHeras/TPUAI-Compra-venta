using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.Composite
{
   public enum Tipopatente
    {
       
        //acceder
        puedeaccederidioma,
        puedecambiarclave,//lo ponemos de una xq el usuario debe poder cambiarlo si o si
        puedeaccederseguridad,
        puedeaccedernegocio,
        puedeaccedermaestros,
        puedeaccederreportes,
        puedepedirayuda,
        //puedever
        puederverselecidioma,//todos
        puedervergestionaridioma,//soloadmin
        puederveractualizaidioma,//soloadmin
        puederverperfiles,//soloadmin
        puederverasignacion,//soloadmin
        puederverabmusuarios,//soloadmin
        puederverventas,//vendedor
        puedervercarrito,//vendedor
        puedeverfacturacion,
        puedevercompras,//repositor
        puederverproudctos,
        puedeverprecios,
        puedervercl,   
        puederverprov, //repositor
        perfil,

    }
}
