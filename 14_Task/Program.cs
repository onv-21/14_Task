// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Cat cat = new Cat("Алиса");
Dog dog = new Dog("Рекс");
cat.ShowInfo();
dog.ShowInfo();

abstract class Animal
{
    string name;
    public abstract string Name { get; set; }
    public Animal (string name)
    {
        Name = name;
    }
    public abstract string Say();
    public void ShowInfo()
    {
        Console.WriteLine("Название животного {0}. {1}", Name, Say());
    }
}
class Cat : Animal
{
    string name;

    public Cat(string name) : base(name)
    {

    }
    public override string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }

    }
    public override string Say()
    {
        return "Мяу";
    }
}
class Dog : Animal
{
    string name;

    public Dog(string name) : base(name)
    {

    }
    public override string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }

    }
    public override string Say()
    {
        return "Гав";
    }
}