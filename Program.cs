using System;
using System.Linq;
using OOPexercise;

namespace OOPExercise
{
     class Program
    {
        public static void Main(string[] args)
        {

            // Console.WriteLine("Insert first person name: ");
            // var firstPersonName = Console.ReadLine();            

            // Console.WriteLine("Insert second person name: ");
            // var secondPersonName = Console.ReadLine();

            // Console.WriteLine("Insert third person name: ");
            // var thirdPersonName = Console.ReadLine();
            // Console.WriteLine(firstPersonName);
            // Console.WriteLine(secondPersonName);
            // Console.WriteLine(thirdPersonName);            

            // var person1 = new Person();
            // person1.Name = firstPersonName;

            //var person2 = new Person();
            //person2.Name = secondPersonName;

            //var person3 = new Person();
            //person3.Name = thirdPersonName;

            // var persons = new Person[3];
            // persons[0] = person1;
            // persons[1] = person2;
            // persons[2] = person3;

            // foreach (var person in persons)
            // {
            //    Console.WriteLine( person.ToString());
            // }
            
            //(Class person, student and teacher)

            /*Person person1 = new Person("Juan");
            person1.Greet();
            person1.ToString();
            Student student = new Student("Ezequiel");
            student.Age = 22;
            student.Greet();
            student.ToString();
            student.ShowAge();
            student.study();
            Teacher teacher = new Teacher("Chin");
            teacher.Greet();
            teacher.Explain();*/


            //(Photo book class)
            
            // Photobook myAlbum1 = new Photobook();
            // Console.WriteLine(myAlbum1.GetNumberPages());
            // Photobook myAlbum2 = new Photobook(24);
            // Console.WriteLine(myAlbum2.GetNumberPages());
            // SuperPhotoBook myBestAlbum= new SuperPhotoBook(64);
            // Console.WriteLine(myBestAlbum.GetNumberPages());
            // Console.Write("Insert first person name: ");
            // var firstPersonName = Console.ReadLine();
            // Console.Write("Insert second person name: ");
            // var secondPersonName = Console.ReadLine();
            // Console.Write("Insert third person name: ");
            // var thirdPersonName = Console.ReadLine();

            //(Inheritance of objects)
            
            // int total = 3;
            // Person[] persons = new Person[total];

            // for (int i = 0; i < total; i++)
            // {
            // if (i == 0)
            // {
            //     persons[i] = new Teacher(Console.ReadLine());
            // }
            // else
            // {
            //     persons[i] = new Student(Console.ReadLine());
            // }
            // } 
            // for (int i = 0; i < total; i++)
            // {
            // if (i == 0)
            // {
            //    ((Teacher)persons[i]).Explain(); 
            // }
            // else
            // {
            //     ((Student)persons[i]).Study();
            // }
            // persons[0].Name = firstPersonName;
            // persons[1].Name = secondPersonName;
            // persons[2].Name = thirdPersonName;
            
            //(Interfaces)

            // Car car1 = new Car(0);
            // Console.WriteLine("ingrese gasolina");
            // int fuel = int.Parse(Console.ReadLine());
            // if (car1.Refuel(fuel))
            // {
            //     car1.Drive();
            // }
            
            //(Abstract classes)

            // Dog dog1 = new Dog();
            // Console.WriteLine("Dog's Name");
            // dog1.SetName(Console.ReadLine());
            // Console.WriteLine(dog1.GetName());
            // dog1.Eat();
        }
    
        }
        
    }
