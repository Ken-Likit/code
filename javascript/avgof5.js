function find_averages(K, arr) {
    let results = [];
    for (let i = 0; i < arr.length - (K - 1); i++) {
        let sum = 0;
        for (let j = i; j < i + 5; j++) {
            sum += arr[j];
        }
        results.push(sum/K);
    }
    return results;
}

function find_averages2(K, arr) {
    let results = [];
    let sum = 0;
    let start = 0;
    for (let i = 0; i < arr.length; i++) {
        sum += arr[i];
        if (i >= (start + K - 1)) {
            results.push(sum / K);
            sum -= arr[start];
            start += 1;
        }
    }
    return results;
}

const output = find_averages(5, [1, 3, 2, 6, -1, 4, 1, 8, 2]);
const output2 = find_averages2(5, [1, 3, 2, 6, -1, 4, 1, 8, 2]);
console.log(`output1 = ${output} \noutput2 = ${output2}`);