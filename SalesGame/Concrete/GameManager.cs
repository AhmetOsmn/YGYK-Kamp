using SalesGame.Abstract;
using SalesGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesGame.Concrete
{
    public class GameManager : IEntityService

    {
        public void Add(IEntity game, List<IEntity> games)
        {
            games.Add(game);
            Console.WriteLine(game.Name + " basariyla eklendi.");
        }

        public void Buy(IEntity customer, IEntity game)
        {
            Console.WriteLine("Fonksiyon hatali kullanildi.");

        }

        public void Delete(IEntity game, List<IEntity> games)
        {
            games.Remove(game);
            Console.WriteLine(game.Name + " kayitlardan silindi.");
        }

        public void Return(IEntity customer, IEntity game)
        {
            Console.WriteLine("Fonksiyon hatali kullanildi.");
        }

        public void Show(List<IEntity> games)
        {
            Console.WriteLine("--------------OYUNLAR[" + games.Count + "]--------------");
            foreach (var game in games)
            {
                Console.WriteLine(game.Name);
            }
            Console.WriteLine("----------------------------");
        }

        public void Update(IEntity game, string N)
        {
            Console.WriteLine(game.Name + " guncellendi");
        }
    }
}
