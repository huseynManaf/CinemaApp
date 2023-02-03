using System;
namespace TaetrProjekt
{
    internal class FilmManager : IPrintService, ICrudService
    {
        private Film[] films = new Film[6];
        private int _currentIndex = 0;
        public void Add(Entity entity)
        {
            if (_currentIndex>6)
            {
                Console.WriteLine("limiti kecdiz 6 film daxil edile biler");
                return;
            }
            films[_currentIndex++] = (Film)entity;
           
        }

        public void Delete(int id)
        {
            bool found = false;
            for (int i = 0; i < films.Length; i++)
            {
                if (films[i] == null)
                    continue;
                if (id == films[i].Id)

                {
                    found = true;

                    for (int j = 0; j < films.Length - 1; j++)
                    {
                        films[j] = films[j + 1];
                    }
                    _currentIndex--;
                    Console.WriteLine($"{id}-li film silindi");
                    return;
                }
            }
            if (!found)
                Console.WriteLine($"{id}-li film tapilmadi!");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < films.Length; i++)
            {
                if (films[i] == null)
                    continue;
                if (films[i].Id == id)
                {

                    return films[i];
                }

            }
            Console.WriteLine("Not found!");

            return null;
        }

       

        public void Print()
        {
            foreach (var item in films)
            {
                if (item == null)
                    continue;
                Console.WriteLine(item.ToString());
            }
        }

       

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < films.Length; i++)
            {
                if (films[i] == null) 
                    continue;
                if (films[i].Id == id)
                {
                    films[i] = (Film)entity;
                    Console.WriteLine("ugurla deyisdirildi!");
                    return;
                }
            }
        }

      
    }
}

