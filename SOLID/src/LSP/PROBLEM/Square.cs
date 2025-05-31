namespace SOLID.LSP.PROBLEM;

public class Square : Rectangle
{
    public override double Width
    {
        get => base.Width;
        set => base.Width = base.Height = value; // Enforce square property
    }
}