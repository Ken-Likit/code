//website: https://www.freecodecamp.org/news/how-to-reverse-a-string-in-javascript-in-3-different-ways-75e4763c68cb/
//hamming weight

function reverseString(str) {
    console.time('String');
    var newStr = '';
    var end = str.length - 1;
   for (var i = end; i >= 0; i--) {
        newStr += str[i];
   }
   console.timeEnd('String');
   console.log(`Original=${str}...New=${newStr}`);
}

function revStringArray(str) {
    console.time('Array');
    var splitString = str.split("");
    var revArr = splitString.reverse();
    var joinArr = revArr.join("");
    console.timeEnd('Array')
    console.log(`Original=${str}...New=${joinArr}`);
}

function revStringRec(str) {
    if (str === '') {
        return '';
    }
    else {
        //console.log(str.substring(1) + ' ' + str[0]);
        return revStringRec(str.substring(1)) + str[0];
    }
}

function revStringXor(input) {
    var str = input.split("");
    var start = 0;
    var end = str.length - 1;
    while (start < end) {
        var x = str[start].charCodeAt(0);
        var y = str[end].charCodeAt(0);
        console.log(`x = ${x} y = ${y}`);
        str[start] = String.fromCharCode(str[start].charCodeAt(0) ^ str[end].charCodeAt(0));
        x = str[start].charCodeAt(0);
        y = str[end].charCodeAt(0);
        console.log(`x = ${x} y = ${y}`);
        str[end] = String.fromCharCode(str[start].charCodeAt(0) ^ str[end].charCodeAt(0));
        x = str[start].charCodeAt(0);
        y = str[end].charCodeAt(0);
        console.log(`x = ${x} y = ${y}`);
        str[start] = String.fromCharCode(str[start].charCodeAt(0) ^ str[end].charCodeAt(0));
        x = str[start].charCodeAt(0);
        y = str[end].charCodeAt(0);
        console.log(`x = ${x} y = ${y}`);
        start++;
        end--;
    }
    return str.join("");

}

reverseString('Hello');
revStringArray('hello');
console.time('Rec');
var x = revStringRec('hello');
console.timeEnd('Rec')
console.log(x);
console.log(revStringXor('hello'))