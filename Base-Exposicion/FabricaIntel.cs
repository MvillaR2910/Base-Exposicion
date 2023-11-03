using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Exposicion
{
    // Paso 4: Implementa fábricas concretas para marcas de componentes (por ejemplo, Intel)
    public class FabricaIntel: FabricaComponentes
    {
        public override ICPU CrearCPU()
        {
            // Implementa la creación de una CPU Intel
            return null;
        }

        public override IRAM CrearRAM()
        {
            // Implementa la creación de una RAM Intel
            return null;
        }

        public override IGPU CrearGPU()
        {
            // Implementa la creación de una GPU Intel
            return null;
        }
    }
}
