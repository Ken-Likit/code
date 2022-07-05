public class Rectangle extends Shape {
    private double width;
    private double length;

    public Rectangle(double w, double l) {
        this.width = w;
        this.length = l;
        this.perimeter = 2 * this.width + 2 * this.length;
    }

    public Rectangle() {
        this.width = 1;
        this.length = 1;
    }

    @Override
    public double calculateArea() {
        return this.width * this.length;
    }
    @Override
    public String toString() {
        return String.format("This is rectangle .. Area = %.2f .. Perimeter = %.2f",
                this.calculateArea(),
                this.perimeter);
    }
}
