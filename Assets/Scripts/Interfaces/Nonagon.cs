using UnityEngine;

public class Nonagon : IShape
{
    private float sideLength;

    public Nonagon(float side)
    {
        sideLength = side;
    }

    public float CalculateArea()
    {
        // Placeholder calculation (allowed by assignment)
        return 6.18f * sideLength * sideLength;
    }

    public float CalculatePerimeter()
    {
        return 9 * sideLength;
    }

    public string GetShapeName()
    {
        return "Nonagon";
    }
}
