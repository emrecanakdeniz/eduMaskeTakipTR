
using Entities.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Soyut
{
    public interface BasvuranService
    {
        void ApplyForMask(Vatandas vatandas);
        List<Vatandas> Getlist();
        bool KontrolVatandas(Vatandas vatandas);
    }
}
