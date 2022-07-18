function test() {
    function containsanychar(str) {
        return /[a-zA-Z]/.test(str);
    }

    function containsanydigit(str) {
        return /[0-9]/.test(str);
    }

    const strlist = [
        'abc123',
        'ABC',
        '123',
        '',
        'XYZ193',
        '1234'
    ];

    strlist.map( (x, i) => {
        const hasLetter = containsanychar(x);
        const hasDigit = containsanydigit(x);
        const noLetters = x.replace(/[a-zA-Z]/g, ''); //<-- gets rid of all letters
        const noDigits = x.replace(/[0-9]/g, '');
        console.log(`\ni=${i} ${x} hasletter --> ${hasLetter} .. hasdigit --> ${hasDigit}`);
        console.log(`Number of digits = ${noLetters.length}...Number of letter = ${noDigits.length}`);
    })

    //const x = containsanychar('abc123');
    //console.log(x);
}

test();