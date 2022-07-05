

public class Circle extends Shape {
    private double radius = 0;

    public Circle(double r) {
        this.radius = r;
        this.perimeter = 2 * Math.PI * this.radius;
    }

    public Circle() {
        this(1);
    }

    @Override
    public double calculateArea() {
        return Math.PI * this.radius * this.radius;
    }

    @Override
    public String toString() {
        return String.format("This is circle .. Area = %.2f .. Perimeter = %.2f",
                this.calculateArea(),
                this.perimeter);
    }



}
