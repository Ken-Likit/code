class Testdata {
    static Students = [
    {
       'id': 001,
       'f_name': 'Alex',
       'l_name': 'B',
       'gender': 'M',
       'married': false,
       'age': 22,
       'paid': 250,
       'courses': ['JavaScript', 'React']
    },
    {
       'id': 002,
       'f_name': 'Ibrahim',
       'l_name': 'M',
       'gender': 'M',
       'married': true,
       'age': 32,
       'paid': 150,
       'courses': ['JavaScript', 'PWA']
    },
    {
       'id': 003,
       'f_name': 'Rubi',
       'l_name': 'S',
       'gender': 'F',
       'married': false,
       'age': 27,
       'paid': 350,
       'courses': ['Blogging', 'React', 'UX']
    },
    {
       'id': 004,
       'f_name': 'Zack',
       'l_name': 'F',
       'gender': 'M',
       'married': true,
       'age': 36,
       'paid': 250,
       'courses': ['Git', 'React', 'Branding']
    }
];
};

function test() {
    const emotions = ['🙂', '😍', '🙄', '😟'];
    const colors = ['red', 'blue', 'green'];
    const names = ['tom', 'alex', 'bob', 'john'];
    const salad = ['🍅', '🍄', '🥦', '🥒', '🌽', '🥕', '🥑'];
    


    console.group('Joining');
    let a = emotions.join('+');
    console.log(`A = ${a}`);
    a = emotions.join();
    console.log(a);
    console.groupEnd();

    console.group('Fill');
    console.log(colors);
    colors.fill('white', 0, 2);
    //colors.fill('white'); fills everything
    console.log(colors);
    console.groupEnd();

    console.group('Includes');
    console.log(names);
    const hasjohn = names.includes('John'.toLowerCase());
    console.log(hasjohn);
    const newnames = names.map(x => x.toUpperCase());
    console.log(newnames);
    const hasnew = newnames.includes('john'.toUpperCase());
    console.log(hasnew);
    const newnames1 = names.map(x => x.toLowerCase()).includes('john');
    console.log(newnames1);
    console.groupEnd();

    console.group('Index of');
    const idxofjohn = names.indexOf('john');
    console.log(idxofjohn);
    console.groupEnd();

    console.group('Reverse');
    console.log(salad);
    salad.reverse();
    console.log(salad);
    console.groupEnd();

    console.group('Sort');
    console.log(names);
    names.sort();
    console.log(names);
    console.groupEnd();

    console.group('Splice');
    console.log(names);
    //const clonednames = names.splice(0);
    //console.log(clonednames);
    const clonednames2 = names.splice(0, 2);
    console.log(clonednames2);
    console.log(names);
    console.groupEnd();

    console.group('Array of');
    const arrayOf = Array.of(2, false, 'test', {'name': 'Alex'});
    console.log(arrayOf);
    console.groupEnd();

    console.group('Filter');
    //console.log(Testdata.Students);
    const femaleStudents =  Testdata.Students.filter((element, index) => element.gender === 'F');

    function filterFunction(element)  { return element.gender === 'F'; };
    const femaleStudents2 = Testdata.Students.filter(x => filterFunction(x));
    console.log(femaleStudents2);
    console.groupEnd();
}

test();