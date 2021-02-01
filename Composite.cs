using System;
using System.Collections.Generic;

namespace CompositePattern
{
  public class Composite : IComponent
  {
    private readonly string _name;
    private readonly List<IComponent> _components;
    public Composite(string name)
    {
      _name = name;
      _components = new List<IComponent>();
    }
    public void Add(IComponent component)
    {
      _components.Add(component);
    }
    public void PrintName()
    {
      Console.WriteLine($"Composite Name: {_name}");
      foreach (var component in _components)
      {
        component.PrintName();
      }
    }
  }
}
