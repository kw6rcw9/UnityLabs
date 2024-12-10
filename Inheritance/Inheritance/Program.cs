namespace Inheritance;

public  class Program
{
    public static void Main()
    {
        Console.WriteLine("Inheritance");
        Tetragon[] tetragons =
        {
            new ConvexTetragon(3,6,2,7,50),
            new Parallelogram(8,14,70),
            new Rectangle(10,5),
            new Rhombus(6,80),
            new Square(2)
        };

        foreach (var tetragon in tetragons)
        {
            Console.WriteLine(tetragon.CountPerimeter());
            Console.WriteLine(tetragon.CountArea());
            Console.WriteLine();
        } 
        Console.WriteLine("With Interface (For test)");
        
        ITetragon[] newTetragons =
        {
            new NewConvexTetragon(3,6,2,7,50),
            new NewParallelogram(8,14,70),
            new NewRectangle(10,5),
            new NewRhombus(6,80),
            new NewSquare(2)
        };

        foreach (var tetragon in tetragons)
        {
            Console.WriteLine(tetragon.CountPerimeter());
            Console.WriteLine(tetragon.CountArea());
            Console.WriteLine();
        } 
    }
}
public interface ITetragon
{
    public float CountPerimeter();
    public float CountArea();
}

public class NewConvexTetragon : ITetragon
{
    protected float SideA;
    protected float SideB;
    protected float SideC;
    protected float SideD;
    protected float AngleAB;
    
    public NewConvexTetragon(float sideA, float sideB, float sideC, float sideD, float angleAB)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        SideD = sideD;
        AngleAB = angleAB;
    }
    
    public virtual float CountPerimeter()
    {
        return SideA + SideB + SideC + SideD;
    }
    
    public virtual float CountArea()
    {
        float p = CountPerimeter() / 2;
        return MathF.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC)*(p-SideD));
    }
}

public class NewParallelogram : NewConvexTetragon
{
    public NewParallelogram(float a, float b, float abAngle) : base(a, b, a, b, abAngle){}
    
    public override float CountPerimeter()
    {
        return SideA*2+SideB*2;
    }
    
    public override float CountArea()
    {
        return SideA*SideB*MathF.Sin(AngleAB);
    }
}

public class NewRhombus : NewParallelogram
{
    public NewRhombus(float a, float abAngle) : base(a, a, abAngle){}
    
    public override float CountPerimeter()
    {
        return SideA * 4;
    }
    
    public override float CountArea()
    {
        return SideA*SideA*MathF.Sin(AngleAB);
    }
}

public class NewRectangle : NewParallelogram
{
    public NewRectangle(float a, float b) : base(a, b, 90){}

    public override float CountArea()
    {
        return SideA*SideB;
    }
}

public class NewSquare : NewRhombus
{
    public NewSquare(float a) : base(a, 90){}

    public override float CountArea()
    {
        return SideA*SideA;
    }
}