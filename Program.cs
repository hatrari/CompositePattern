using System;

namespace CompositePattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var root = new Composite("Classification of Animals");
      var invertebrates = new Composite("+ Invertebrates");
      var vertebrates = new Composite("+ Vertebrates");
      var warmBlooded = new Leaf("-- Warm-Blooded");
      var coldBlooded = new Leaf("-- Cold-Blooded");
      var withJointedLegs = new Leaf("-- With Jointed-Legs");
      var withoutLegs = new Leaf("-- Without Legs");
      
      invertebrates.Add(withJointedLegs);
      invertebrates.Add(withoutLegs);
      
      vertebrates.Add(warmBlooded);
      vertebrates.Add(coldBlooded);
      
      root.Add(invertebrates);
      root.Add(vertebrates);
      root.PrintName();
    }
  }
}
