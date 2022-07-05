public class Bicycle extends Vehicle {

    int wheels = 2;
    @Override
    void move() {
        System.out.printf("Person has %d\n", wheels);
    }
}
