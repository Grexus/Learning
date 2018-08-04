// Function Constructor

// var Person = function(name, yearOfBirth, job) {
//     this.name = name;
//     this.yearOfBirth = yearOfBirth;
//     this.job = job;
// }

// Person.prototype.calculateAge = function() {
//     console.log(2018 - this.yearOfBirth);
// }

// Person.prototype.lastName = 'Smith';

// var john = new Person('John', 1990, 'teacher');
// var matthew = new Person('Matthew', 1994, 'Web Designer');

// Object.create
// var personProto = {
//     calculateAge: function() {
//         console.log(2018 - this.yearOfBirth);
//     }
// }

// var john = Object.create(personProto);
// john.name = 'John';
// john.yearOfBirth = 1990;
// john.job = 'teacher';

// var jane = Object.create(personProto,
//     {
//         name: { value: 'Jane'},
//         yearOfBirth: { vale: 1960 },
//         job: { value: 'Dish Washer'}
//     }
// );

// Primitives vs Objects

// // Primitives
// var a = 23;
// var b = a;
// a = 46;

// console.log(a);
// console.log(b);

// // Objects
// var obj1 = {
//     name: 'John',
//     age: 26
// }

// var obj2 = obj1;
// obj1.age = 30;

// console.log(obj1.age);
// console.log(obj2.age);

// // Functions
// var age = 23;
// var obj = {
//     name: 'Matthew',
//     city: 'Fgura'
// }

// function change(a, b){
//     a = 30;
//     b.city = 'Budapest';
// }

// change(age, obj);
// console.log(age);
// console.log(obj.city);

// Lecture: Passing functions as arguments

// var years = [1990, 1965, 1937, 2015, 1998];

// function arrayCalc(arr, fn) {
//     var arrRes = [];
//     for (i = 0; i < arr.length; i++) {
//         arrRes.push(fn(arr[i]));
//     }
//     return arrRes;
// }

// function calculateAge(el) {
//     return 2018 - el;
// }

// function isFullAge(el) {
//     return el >= 18;
// }

// function maxHeartRate(el) {
//     if (el >= 18 && el <= 81) {
//         return Math.round(206.9 - (0.67 * el));
//     }
// }

// var ages = arrayCalc(years, calculateAge);
// console.log(ages);

// var fullAges = arrayCalc(ages, isFullAge);
// console.log(fullAges);

// var heartRate = arrayCalc(ages, maxHeartRate);
// console.log(heartRate);

// First Class Function A.K.A. Function returning functions

// function interviewQuestion(job) {
//     if (job === 'designer') {
//         return function(name) {
//             console.log(name + ', can you please explain what UX design is?');
//         }
//     } else if (job === 'teacher') {
//         return function(name) {
//             console.log('What subject do you teach, ' + name + '?');
//         }
//     } else {
//         return function(name) {
//             console.log('Hello ' + name + ', what do you do?');
//         }
//     }
// }

// var teacherQuestion = interviewQuestion('teacher');
// teacherQuestion('John');

// var designerQuestion = interviewQuestion('designer');
// designerQuestion('Matthew');

// interviewQuestion('teacher')('Mark');

// Immediately Invoked Function Expressions (IIFE)

// function game() {
//     var score = Math.random() * 10;
//     console.log(score >= 5);
// }
// game();

// Same as

// (function(){
//     var score = Math.random() * 10;
//     console.log(score >= 5);
// })();

// (function(goodLuck){
//     var score = Math.random() * 10;
//     console.log(score >= 5 - goodLuck);
// })(5);