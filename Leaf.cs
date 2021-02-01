using System;

namespace CompositePattern
{
  public class Leaf : IComponent
  {
    private readonly string _name;
    public Leaf(string name)
    {
      _name = name;
    }
    public void PrintName()
    {
      Console.WriteLine($"Leaf Name: {_name}");
    }
  }
}
