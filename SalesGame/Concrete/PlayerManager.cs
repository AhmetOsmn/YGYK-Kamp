using SalesGame.Abstract;
using SalesGame.Entities;
using System;
using System.Collections.Generic;

namespace SalesGame.Concrete
{
    public class PlayerManager : IEntityService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(IEntity entity, List<IEntity> entities)
        {
            if (_userValidationService.Validate(entity))
            {
                entities.Add(entity);
                Console.WriteLine(entity.Name + " basariyla eklendi.");
            }
            else
            {
                Console.WriteLine("Dogrulama Basarisiz...");
            }
           
        }
    

        public void Buy(IEntity players, IEntity game)
        {
            Console.WriteLine(players.Name + " : " + game.Name +" oyununu satin aldi.");
        }

        public void Delete(IEntity player, List<IEntity> players)
        {
            players.Remove(player);
            Console.WriteLine(player.Name + " kayitlardan silindi.");
        }

        public void Return(IEntity player, IEntity game)
        {
            Console.WriteLine(player.Name + " " + " isimli kullanici, " + game.Name + " isimli oyunu iade etti.");
        }

        public void Show(List<IEntity> players)
        {
            Console.WriteLine("--------------KULLANİCİLAR[" + players.Count + "]--------------");
            foreach (var player in players)
            {
                Console.WriteLine(player.Name);
            }
            Console.WriteLine("----------------------------");
        }

        public void Update(IEntity players, string N)
        {
            Console.WriteLine(players.Name +  "  bilgileri guncellendi..");

            players.Name = N;
           
        }
    }
}
