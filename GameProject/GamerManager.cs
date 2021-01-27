using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //siniflari ciplak birakmiyoruz
    //bir manager sinifinda, baska bir manager sinifini kullanacaksak kesinlikle new yapmiyoruz.
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            //Kullanici kayit olurken, kullanicinin dogrulanmasini istiyoruz.
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayit oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama basarisiz, kayit basarisiz.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit guncellendi");
        }
    }
}
