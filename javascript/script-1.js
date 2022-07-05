function fib(num) {
    if (num < 2) {
        return num;
    }
    else {
        return fib(num-1) + fib(num-2);
    }

}

console.log(fib(0));