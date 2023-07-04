public class Color {
    public uint _Red {get; private set;}
    public uint _Green {get; private set;}
    public uint _Blue {get; private set;}
    


    public void setColor(uint r, uint g, uint b) {
        _Red = r;
        _Green = g;
        _Blue = b;
    }

    public void displayColor() {
        Console.WriteLine($"({_Red}, {_Green}, {_Blue})");
    }
    public static Color White() {
        Color color = new Color();
        color.setColor(255, 255, 255);
        return color;
    }
    public static Color Black() {
        Color color = new Color();
        color.setColor(0,0,0);
        return color;
    }
    public static Color Blue() {
        Color color = new Color();
        color.setColor(0, 0, 255);
        return color;
    }
    public static Color Red() {
        Color color = new Color();
        color.setColor(255, 0, 0);
        return color;
    }
    public static Color Green() {
        Color color = new Color();
        color.setColor(0, 255, 0);
        return color;
    }
    public static Color Yellow() {
        Color color = new Color();
        color.setColor(255, 255, 0);
        return color;
    }
    public static Color Orange() {
        Color color = new Color();
        color.setColor(255, 165, 0);
        return color;
    }
    public static Color Purple() {
        Color color = new Color();
        color.setColor(128, 0, 128);
        return color;
    }
}