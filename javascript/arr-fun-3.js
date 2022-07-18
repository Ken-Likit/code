function test() {
    const emotions = ['🙂', '😍', '🙄', '😟'];
    const colors = ['red', 'blue', 'green'];
    const names = ['tom', 'alex', 'bob', 'john'];
    const salad = ['🍅', '🍄', '🥦', '🥒', '🌽', '🥕', '🥑'];

    console.group('empty array approach 1');
    const numarr = [1, 2, 3];
    numarr.length = 0;
    console.log(`numarr.length = ${numarr.length}`);
    console.groupEnd();

    console.group('performance in time');
    let myArray = ['My', 'Array'];
    let yourArray = ['Some', 'thing'];
    yourArray = myArray;
    console.log(yourArray);

    console.time('Approach 1: arr.length = 0');
    myArray.length = 0;
    console.timeEnd('Approach 1: arr.length = 0');  // Approach 1: arr.length = 0: 0.03ms

    console.group('Approach 1: Empty array using arr.length property of the Array')
    console.log('myArray =>', myArray);
    console.log('yourArray =>', yourArray);
    console.groupEnd();
    
    console.group('empty approach 2');
    let numarr1 = [1, 2, 3, 4, 5];
    console.time('Approach 2: arr = []');
    numarr1 = [];
    console.timeEnd('Approach 2: arr = []');
    console.groupEnd();

    console.group('pop');
    let numarr2 = [1, 2, 3, 4, 5];
    console.time('Approach 3: pop');
    while (numarr2.length > 0) {
        numarr2.pop();
    }
    console.timeEnd('Approach 3: pop');
    console.groupEnd();


    console.group('shift');
    let numarr3 = [1, 2, 3, 4, 5];
    console.time('Approach 4: shift');
    while (numarr2.length > 0) {
        numarr2.shift();
    }
    console.timeEnd('Approach 4: shift');
    console.groupEnd();

    console.group('splice');
    let numarr4 = [1, 2, 3, 4, 5];
    //numarr4.splice(2, 0, 9,10);
    //console.log(numarr4);
    console.time('Approach 5: splice');
    numarr4.splice(0, numarr4.length);
    console.timeEnd('Approach 5: splice')
    console.groupEnd();

}

test();