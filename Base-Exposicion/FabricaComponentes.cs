using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Exposicion
{
    // Paso 3: Define la fábrica abstracta
    public abstract class FabricaComponentes
    {
        public abstract ICPU CrearCPU();
        public abstract IRAM CrearRAM();
        public abstract IGPU CrearGPU();
    }
}
