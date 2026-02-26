# Unity Interface Assignment – IShape Implementation

## 📘 Overview
This project demonstrates the use of **interfaces in C# within Unity**.  
A common interface `IShape` is defined and implemented by multiple shape classes.  
Each shape provides its own logic for calculating area and perimeter while sharing the same method structure.

The project showcases:
- Interface design
- Class implementation
- Polymorphism
- Console output testing in Unity

---

## 🧩 Interface Design

The `IShape` interface defines behaviors shared by all shapes:

- CalculateArea()
- CalculatePerimeter()
- GetShapeName()

All shape classes must implement these methods.

---

## 🔷 Implemented Shapes

The following classes implement the `IShape` interface:

- **Circle**
- **Trapezium**
- **Nonagon**

Each class:
- Stores its own dimensions
- Implements area and perimeter calculations
- Returns its shape name

---

## ▶️ Testing

Testing is performed in `InterfaceTestScript.cs`.

When the Unity scene starts:
1. Shape objects are instantiated using the `IShape` interface.
2. Each shape is passed into a testing method.
3. Results are printed to the Unity Console using `Debug.Log()`.

Example console output:
Circle | Area: 78.54 | Perimeter: 31.42
Trapezium | Area: 15.00 | Perimeter: 16.00
Nonagon | Area: 24.72 | Perimeter: 18.00

## 🧠 Key Concepts Demonstrated

- Interfaces in C#
- Polymorphism
- Abstraction
- Unity MonoBehaviour lifecycle (`Start()` method)

---

## 📁 Project Structure

Assets/
└── Scripts/
└── Interfaces/
├── IShape.cs
├── Circle.cs
├── Trapezium.cs
├── Nonagon.cs
└── InterfaceTestScript.cs
