namespace MVCDog.Models
{
    public class DataService
    {
        static List<Dog> Dogs = new List<Dog>()
        {
            new Dog{Id = 1, Name = "Fluffy", Age = 4 } 
        };

        public void Add(Dog dog) 
        { 
            Dogs.Add(dog); 
        }
        public void Remove(Dog dog)
        {
            Dogs.Remove(dog);
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
