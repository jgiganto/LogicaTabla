using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTabla
{
    public class ServicioTabla : IServicioTabla
    {
        public List<int> GetSecuenciaTabla(int numero)
        {
            List<int> resultado = new List<int>();
            
            for(int i = 0; i < 10; i++)
            {
                int producto = i * numero;
                resultado.Add(producto);
            }
            return resultado;
        }
    }
}
