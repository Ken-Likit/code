public class Triangle extends Shape {
    private double blen;
    private double height;


    public Triangle(double b, double h) {
        this.blen = b;
        this.height = h;
    }

    public Triangle() {
        this(1, 1);
    }

    @Override
    public double calculateArea() {
        return 0.5 * this.blen * this.height;
    }

    @Override
    public String toString() {
        return "This is triangle .. Area = " + this.calculateArea();
    }
}
