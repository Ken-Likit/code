using System.Runtime.InteropServices;
using System;

//-------------------------------------------------------
// Enum
//-------------------------------------------------------
public enum EngineTypeEnum {
  Straight,
  Inline,
  Flat,
  VEngine
}

//-------------------------------------------------------
// Interface
//-------------------------------------------------------
public interface ICar {
  void Accelerate();
  Boolean IsFWD { get; }  // Ex of property in interface 
}

//-------------------------------------------------------
// Abstract base class
//-------------------------------------------------------
public abstract class BaseCar {
  protected string model;  // Ex of property in abstract base class
  protected string brand;
  protected string type;
  protected EngineTypeEnum engineType;

  // Ctors
  public BaseCar(string brand, string model, string type, EngineTypeEnum engineType) {
    this.brand = brand;
    this.model = model;
    this.type = type;
    this.engineType = engineType;
  }

  // Properties
  string Model { get => model; set => model = value; }
  string Brand { get => brand; set => brand = value; }
  string Type { get => type; set => type = value; }
  EngineTypeEnum EngineType { get => engineType; set => engineType = value; }

  public override string ToString()
  {
    return ($"Car brand={brand} type={type} engineType={engineType} model={model}\n");
  }
}

//-------------------------------------------------------
// Derived class: ElectricCar
//-------------------------------------------------------
public class ElectricCar : BaseCar, ICar  // Base class comes first
{
  public ElectricCar(string brand, string model, string type, EngineTypeEnum engineType) 
  : base(brand, model, type, engineType) {}

  public virtual bool IsFWD => true;

  public virtual void Accelerate() => Console.WriteLine($"Accelerating an electric car.");
}

public class GreenElectricCar : ElectricCar
{
  public GreenElectricCar() 
  : base("Green", "GREEN-X", "SUV", EngineTypeEnum.VEngine) 
  {}

  public override bool IsFWD => base.IsFWD;

  public override void Accelerate()
  {
    base.Accelerate();
  }

  public override bool Equals(object obj)
  {
    return base.Equals(obj);
  }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }

  public override string ToString()
  {
    return base.ToString();
  }
}

// C# 9.0 - no need for static void main..
// public class Driver {
//   public static void Main(string[] args) {
//     ICar carA = new ElectricCar("Tesla", "X", "battery");
//     carA.ToString();
//   }
// }

Console.WriteLine("Hello world");

ICar carA = new ElectricCar("Tesla", "X", "battery", EngineTypeEnum.Straight);
carA.Accelerate();
Console.Write(carA.ToString());

var greenCar = new GreenElectricCar();
Console.Write(greenCar.ToString());


// Print Enum
int straightInt = (int)EngineTypeEnum.Straight;
Console.WriteLine($"{EngineTypeEnum.Straight} {straightInt}");