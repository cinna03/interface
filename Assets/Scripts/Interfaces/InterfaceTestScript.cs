using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    void Start()
    {
        IShape circle = new Circle(5f);
        IShape trapezium = new Trapezium(4f, 6f, 3f, 3f, 5f);
        IShape nonagon = new Nonagon(2f);

        TestShape(circle);
        TestShape(trapezium);
        TestShape(nonagon);
    }

    void TestShape(IShape shape)
    {
        Debug.Log(
            shape.GetShapeName() +
            " | Area: " + shape.CalculateArea().ToString("F2") +
            " | Perimeter: " + shape.CalculatePerimeter().ToString("F2")
        );
    }
}