namespace MVCDog.Models
{
    public class DogService
    {
        static List<Dog> Dogs = new List<Dog>()
        {
            new Dog{Id = 0, Name = "Fluffy", Age = 4 } 
        };

        public void Add(Dog dog) 
        {
            if(Dogs.Count != 0)
            {  
                 dog.Id = Dogs.Max(o => o.Id); 
            }
            Dogs.Add(dog); 
        }
        public void Remove(Dog dog)
        {
            Dogs.Remove(dog);
        }

        public void EditDog(Dog dog) 
        {
            GetDogById(dog.Id);
            dog.Name = dog.Name;
            dog.Age= dog.Age;
        }

        public Dog[] GetAllDogs()
        {
            return Dogs.ToArray();
        }
        public Dog GetDogById(int id)
        {
            return Dogs.Single(o => o.Id == id);
        }
    }
}
