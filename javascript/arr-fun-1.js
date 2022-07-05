function test() {
    const salad = ['🍅', '🍄', '🥦', '🥒', '🌽', '🥕', '🥑'];
    /*
    console.log(salad);
    console.log(`salad = ${salad} len = ${salad.length}`);
    salad.map(x => console.log(x));
    salad.forEach(x => console.log(x));
    salad.map((x, i) => console.log(`i = ${i} x = ${x}`));
    salad.forEach((x, i) => console.log(`i = ${i} x = ${x}`));
    ^ print salad in different ways
    salad.push('🥜'); add at the end
    console.log(`salad = ${salad} len = ${salad.length}`);
    salad.unshift('🥜'); add at the end
    console.log(`salad = ${salad} len = ${salad.length}`);

    salad.push('🥜'); 
    console.log(`salad = ${salad} len = ${salad.length}`);
    salad.pop();
    console.log(`salad = ${salad} len = ${salad.length}`);
    
    salad.unshift('🥜'); 
    console.log(`salad = ${salad} len = ${salad.length}`);
    salad.shift();
    console.log(`salad = ${salad} len = ${salad.length}`);
    */

    console.group(`Adding element`);
    salad.push('🥜'); 
    console.log(`salad = ${salad} len = ${salad.length}`);
    salad.unshift('🥜'); 
    console.log(`salad = ${salad} len = ${salad.length}`);
    console.groupEnd();


    console.group(`Removing element`);
    salad.pop(); 
    console.log(`salad = ${salad} len = ${salad.length}`);
    salad.shift(); 
    console.log(`salad = ${salad} len = ${salad.length}`);
    console.groupEnd();
}

test();