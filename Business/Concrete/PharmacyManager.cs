using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PharmacyManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PharmacyManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Citizen citizen)
        {
            if (_applicantService.CheckPerson(citizen))
            {
                Console.WriteLine(citizen.FirstName + ", kişisi için maske verildi.");
            }
            else if (_applicantService.CheckPerson(citizen) == false)
            {
                Console.WriteLine(citizen.FirstName + ", kişi T.C. vatandaşı değil!");
            }
            else
            {
                Console.WriteLine("Vatandaş kontrolünde bir sorun oluştu...");
            }
        }
    }
}
