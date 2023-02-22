using AsincronaS5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsincronaS5.Negocio
{
    public class ClsDatos
    {
        public int Contador(Datos dat)
        {
            for (int i = dat.inicio; i <= dat.fin; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                    dat.count++;
                }
            }
            return dat.count;
        }
    }
}
