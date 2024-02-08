using System.Drawing;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.area_rectangle(1, 10);
            Console.WriteLine('\n');
            rectangle.perimeter_rectangle(4, 32);

            Keyboard keyboard= new Keyboard(true, 96, Color.Pink);
            Keyboard keyboard1 = new Keyboard(true, 107, Color.White);


        }
    }
}
class Rectangle
{
    private int _x;
    private int _y;
    Rectangle(int x, int y)
    {
        _x = x;
        _y = y;
    }
    public Rectangle()
    {

    }
    public void area_rectangle(int _x, int _y)
    {
        int s = _x * _y;
        Console.WriteLine(s+" это площадь");
    }
    public void perimeter_rectangle(int _x, int _y)
    {
        int s = 2*(_x+_y);
        Console.WriteLine(s+" это периметр");
    }
}
class Keyboard 
{
    private bool _backlight;
    private int _buttons;
    private Color _color;

    public Keyboard(bool backlight, int buttons, Color color)
    {
        _backlight = backlight;
        _buttons = buttons;
        _color = color;
    }
    public Keyboard()
    {

    }
}
public enum Mechanical_Membrane
{
    Mechanical, Membrane
}