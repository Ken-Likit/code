public class App {
    public static void main(String args[]) {
        Vehicle car = new Car();
        car.move();
        Vehicle bike = new Bicycle();
        bike.move();
        Vehicle plane = new Plane();
        plane.move();
    }
}
