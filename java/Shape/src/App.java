

public class App {

    public static void main (String args []) {
        Shape rectangle = new Rectangle();
        Shape rectangle2 = new Rectangle(5, 6);
        Shape circle = new Circle(4);
        Shape triangle = new Triangle(4, 5);
        Shape square = new Square();
        //System.out.printf("Rectangle area = %f", rectangle.calculateArea());
        System.out.println(rectangle);
        System.out.println(rectangle2);
        System.out.println(circle);
        System.out.println(triangle);
        System.out.println(square);
    }
}
