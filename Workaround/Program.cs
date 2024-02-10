using Business.Concrete;
using Entities.Concrete;

//PttManager pttManager = new PttManager(new CitizenManager());
//pttManager.GiveMask(new Citizen()
//{
//    FirstName = "Anıl",
//    LastName = "Aygün",
//    DateOfBirthYear = 2001,
//    NationalIdentity = 36877456987
//});

PharmacyManager pharmacyManager = new PharmacyManager(new CitizenManager());
pharmacyManager.GiveMask(new Citizen()
{
    FirstName = "Anıl",
    LastName = "Aygün",
    DateOfBirthYear = 2001,
    NationalIdentity = 1
});

