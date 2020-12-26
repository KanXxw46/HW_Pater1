using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    public interface IAnimal
    {
        void Sound();
    }
    public interface IAnimalFactory
    {
        IAnimal Create(AnimalType animalType);
    }
    public enum AnimalType
    { Cat,Dog}
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal Create(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Cat:
                    return new MyCat();
                case AnimalType.Dog:
                    return new MyDog();
                default:
                    return new MyCat();
            }
        }
        public class MyCat : IAnimal
        {
            public void Sound()
            {
                Console.WriteLine("Meo");
            }
        }
        public class MyDog : IAnimal
        {
            public void Sound()
            {
                Console.WriteLine("Wouf");
            }
        }
    }
    public class Dummy
    {

    }
    public class CatService : ITest2<Cat, Dummy>
    {
        public void Create(Cat t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cat> getAll()
        {
            throw new NotImplementedException();
        }

        public Cat getById(int Id)
        {
            throw new NotImplementedException();
        }

        public Dummy getConnect(string ConStr)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Cat t)
        {
            throw new NotImplementedException();
        }
    }

    public interface ITest2<T,Q> where T : AnimalBase where Q : class
    {
        T getById(int Id);
        IEnumerable<T> getAll();
        void Create(T t);
        void Update(int Id, T t);
        void Delete(int Id);

        Q getConnect(string ConStr);
    } 


    public interface ITest<T> where T : AnimalBase
    {
        T getById(int Id);
        IEnumerable<T> getAll();
        void Create(T t);
        void Update(int Id,T t);
        void Delete(int Id);
    }

    public class Cat2Service : ITest<Cat>
    {
        public void Create(Cat t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cat> getAll()
        {
            throw new NotImplementedException();
        }

        public Cat getById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Cat t)
        {
            throw new NotImplementedException();
        }
    }
    public class DogService : ITest<Dog>
    {
        public void Create(Dog t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dog> getAll()
        {
            throw new NotImplementedException();
        }

        public Dog getById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Dog t)
        {
            throw new NotImplementedException();
        }
    }

    public class Inherited : AnimalBaseAbstract,IMyInterface_1, IMyInterface_2
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public new string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string get1()
        {
            throw new NotImplementedException();
        }
        public void Method_1()
        {
        }

        public string Method_2()
        {
            throw new NotImplementedException();
        }

        public string Method_3()
        {
            throw new NotImplementedException();
        }
    }

    public interface IMyInterface_1
    { 
        int Id { get; set; }
        string Name { get; set; }

        public void Method_1();
        
        string Method_2();

    }
    public interface IMyInterface_2
    {
        string Method_2();
        string Method_3();
    }
    public interface IMyInterface_3 :IMyInterface_1
    {
        string Method_4();
    }
    public class MyConstructor
    {
        private MyConstructor()
        {
        
        }
        //public MyConstructor(int id)
        //{
        //    this.Id = id;
        //}
        //public MyConstructor(string id)
        //{
        //    this.Id = int.Parse(id);
        //}
        public int Id { get; set; }
    }
    public abstract class AnimalBaseAbstract
    {
        public DateTime dt;
        public AnimalBaseAbstract()
        {
            
        }
        public  AnimalBaseAbstract(DateTime DT)
        {
            dt = DT;
        }
        public string Name { get; set; }
        public abstract string get1();
        public string get2()
        {
            return null;
        }

        public virtual string get3()
        {
            return "Print get3";
        }
    }

    public class AnimalBaseAbstract_child1 : AnimalBaseAbstract
    {
        public override string get1()
        {
            return "AnimalBaseAbstract_child1";
        }
    }
    public class AnimalBaseAbstract_child2 : AnimalBaseAbstract
    {
        public override string get1()
        {
            return "AnimalBaseAbstract_child2";
        }
    }
    public class AnimalBaseAbstract_child3 : AnimalBaseAbstract
    {
        public AnimalBaseAbstract_child3(DateTime DT) : base(DT)
        { }
        public override string get1()
        {
            return "AnimalBaseAbstract_child2";
        }
    }
    public class AnimalBase
    {
        private string Name { get; set; }
        public string Name1 { get; set; }

        protected string Name2
        {
            get
            {
                return "Hello";
            }
        }

        protected string Name3 { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Print AnimaleBase");
        }
    }

    public class Dog : AnimalBase
    {
        public void Go()
        {
            Console.WriteLine(Name2);
        }

        public override void Print()
        {
            Console.WriteLine("Print Dog");
        }
    }

    public class Cat : AnimalBase
    {
        public override void Print()
        {
            Console.WriteLine("Print Cat");
        }
        public  void PrintCat()
        {
            Console.WriteLine("Print Cat owner");
        }
    }

    public class Cat1 : Cat
    {
        
    }
}
