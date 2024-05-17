class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk() { }         // Vehicle method 
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field

  public void ArbitrarySink() { }
}

class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car();
    myCar.honk();
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
    ArbitrarySink(myCar.brand);
  }
}