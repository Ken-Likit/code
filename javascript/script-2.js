function fib(num) {
    if (num < 2) return num;
    return fib(num-1) + fib(num-2);
}
const output = fib(6);
let output2 = output;
output2 = output2 + 1;
let hello = ' hello there'
//console.log(`Output = ${output} \nOutput2 = ${output2}`);
let message = `Output = ${output} \nOutput2 = ${output2}`;
console.log(message + hello);

