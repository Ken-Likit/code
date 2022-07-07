//https://www.javascripttutorial.net/es6/javascript-map/
const Roles = {
    Admin: "Administrator Role",
    Editor: "Editor Role",
    Subscriber: "Subscriber Role"
}

function test() {

    let john = {name: 'John Doe'},
        lily = {name: 'Lily Bush'},
        peter = {name: 'Peter Drucker'};
    let jim = {name: 'Jim Henry'};
    
    let userRoles = new Map();

    console.group('Add elements to map');
    userRoles.set(john, Roles.Admin);
    userRoles
    .set(lily, Roles.Editor)
    .set(peter, Roles.Subscriber);
    console.log(userRoles);
    userRoles.forEach((v, k) => console.log(`k=${k.name} ... v=${v}`) );
    console.groupEnd();

    console.group('Iterate through map');
    for (const k of userRoles.keys()) {
        const v = userRoles.get(k);
        console.log(k.name, v);
    }

    for (const v of userRoles.values()) {
        console.log(v);
    }

    for (const [k, v] of userRoles.entries()) {
        console.log(k,v);
    }
    console.groupEnd();

    console.group('Has elements');
    const hasJohn = userRoles.has(john);
    const hasJim = userRoles.has(jim);
    console.log(hasJohn);
    console.log(hasJim);
    console.groupEnd();

    console.group('Delete element');
    if (!userRoles.has(jim)) {
        userRoles.set(jim, Roles.Subscriber);
        console.log('Jim added');
    }

    if (userRoles.has(jim)) {
        userRoles.delete(jim);
        console.log('Jim deleted');
    }
    console.groupEnd();

    console.group('Spread Operator');
    console.log(userRoles.keys());
    const keys = [...userRoles.keys()];
    console.log(keys);

    const values = [...userRoles.values()];
    console.log(values);

    console.groupEnd();

    /*
    console.group('delete all elements');
    userRoles.clear();
    console.log(userRoles.size);
    console.groupEnd();
*/
}

test();