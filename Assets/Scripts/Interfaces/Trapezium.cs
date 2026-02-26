using UnityEngine;

public class Trapezium : IShape
{
    private float a, b, c, d, height;

    public Trapezium(float sideA, float sideB, float sideC, float sideD, float h)
    {
        a = sideA;
        b = sideB;
        c = sideC;
        d = sideD;
        height = h;
    }

    public float CalculateArea()
    {
        return 0.5f * (a + b) * height;
    }

    public float CalculatePerimeter()
    {
        return a + b + c + d;
    }

    public string GetShapeName()
    {
        return "Trapezium";
    }
}