using Business.Abstract;
using Entities.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CitizenManager : IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Citizen citizen)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(citizen.NationalIdentity, citizen.FirstName, citizen.LastName, citizen.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Citizen> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
