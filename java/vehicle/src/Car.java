public class Car extends Vehicle {

    @Override
    void move() {
        System.out.printf("Engine has %d\n", wheels);
    }
}
