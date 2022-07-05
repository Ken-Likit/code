class Person {
    static StaticPerson = 'Static Person';

    constructor (name, age, id) {
        this.name = name;
        this.age = age;
        this.id = id;
    }

    toString() {
        return `name = ${this.name}, Age = ${this.age}, id = ${this.id}`;
    }
    
}

const person = new Person('Ken', 20, 19211);
//console.log(person.toString());
console.log(`Hello World ${person}`);