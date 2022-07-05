public class Square extends Rectangle{
    public Square(double side) {
        super(side,side);
    }

    public Square () {
        super();
    }

    @Override
    public String toString() {
        return String.format("This is Square .. Area = %.2f .. Perimeter = %.2f",
                this.calculateArea(),
                this.perimeter);
    }}
