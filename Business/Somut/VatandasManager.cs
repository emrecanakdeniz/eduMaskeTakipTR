using Business.Soyut;
using Entities.Somut;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Somut
{
    public class VatandasManager : BasvuranService
    {
        public void ApplyForMask(Vatandas vatandas)
        {

        }
        public List<Vatandas> Getlist() //list of vatandas alisveris sitesindeki urunleri listele gibi
        {
            return null;
        }
        public bool KontrolVatandas(Vatandas vatandas)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody
                (vatandas.TcNo, vatandas.Ad, vatandas.Soyad, vatandas.DogumYili))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
