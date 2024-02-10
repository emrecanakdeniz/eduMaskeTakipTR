using Business.Soyut;
using Entities.Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Somut
{
    public class PttManager : DagiticiService
    {
        private BasvuranService _basvuranService;
        public PttManager(BasvuranService basvuranService)
        {
            _basvuranService = basvuranService;
        }
        public void MaskeVer(Vatandas vatandas)
        {
            if (_basvuranService.KontrolVatandas(vatandas))
            {
                Console.WriteLine(vatandas.Ad + " icin maske verildi");
            }
            else
            {
                Console.WriteLine(vatandas.Ad + " icin maske verilemedi");
            }
        }
    }
}
