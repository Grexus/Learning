// Variables 1 - Different Variables

// var name = "John"; // String
// var lastName = "Smith"; // String
// var age = "26"; // Number 
// var fullAge = true; // Boolean

// ---------------------------------------------------------------------//

// Variables 2 - Prompts, Alerts & Type Coercion 

// var fullName = prompt("Provide a random name");
// var age = "23"; 
// var fullAge = true; 
// var job = "Web Designer"

// alert(fullName + " is a " + age + ' year old ' + job);

// ---------------------------------------------------------------------//

// Operators 

// var name = "John"
// var age = 23;
// var presentYear = 2018;
// var birthYear = presentYear - age;

// console.log(name + " was born in " + birthYear);


// age++; // Increment age by 1

// console.log(name + " will be " + age + " years old next year");

// ---------------------------------------------------------------------//

// If / Else Statements

// var name = "John";
// var age = 23;
// var isMarried = false;

// if (isMarried) {
//     console.log(name + " is married.");
// } else {
//     console.log(name + " is forever alone.");
// }

// ---------------------------------------------------------------------//

// Boolean Logic

// var age = 19; //Try different ages

// if (age <= 12) {
//     console.log('John is a kid.');
// } else if (age >= 13 && age <= 19) {
//     console.log('John is a teenager.');
// } else {
//     console.log('John is a man!');
// }

// ---------------------------------------------------------------------//

// Switch Statement

// var job = prompt("What does John do?");

// switch (job) {
//     case 'teacher':
//         console.log('John teaches kids.');
//         break;
//     case 'web designer':
//         console.log('John designs websites');
//         break;
//     default:
//         console.log('John does something else');
// }

// ---------------------------------------------------------------------//

// Functions

// // Calculate Age
// function calcAge(yearOfBirth) {
//     var age = 2018 - yearOfBirth;
//     return age;
// }

// var ageJohn = calcAge(1990);
// var ageMike = calcAge(1954);
// var ageTony = calcAge(1940);

// console.log('John is ' + ageJohn + " years old.");
// console.log('Mike is ' + ageMike + " years old.");
// console.log('Tony is ' + ageTony + " years old.");

// // Calculate Years Until Retirement
// function yearsUntilRetirement(name, year){
//     var age = calcAge(year);
//     var retirement = 64 - age;

//     if (retirement > 0) {
//         console.log(name + " will retire in " + retirement + " years." );
//     } else if (retirement === 0) {
//         console.log(name + " retires this year." );
//     } else  {
//         console.log(name + " has already retired.");
//     }
// }

// yearsUntilRetirement('John', 1990);
// yearsUntilRetirement('Mike', 1954);
// yearsUntilRetirement('Tony', 1940);

// ---------------------------------------------------------------------//

// Statements & Expression

// // Statement - Performs an Action
// function functionName(input){
//     // code
// }

// // Expression - Produces a Value
// var functionName = function(input) {
//     // code
// }

// ---------------------------------------------------------------------//

// // Arrays

// var names = ["John", "Mike", "Tony"];
// var birthYear = [1990, 1954, 1940];

// // Get an element from an array
// console.log(names[1]);

// // Change an element in an array
// names[0] = "Ben";
// console.log(names);

// // Add an element at the end of an array
// names.push("Mary");
// birthYear.push(1986);

// // Add an element at the beginnen of an array
// names.unshift("Glenn");
// birthYear.unshift("1994");

// // Remove an element at the end of an array
// names.pop();
// birthYear.pop();

// // Remove an element at the beginning of an array
// names.shift();
// birthYear.shift();

// // Return position of element 
// names.indexOf("Mike");

// if (names.indexOf("John") === -1) {
//     console.log("John is not on the list");
// } else {
//     console.log("John is on the list");
// }

// ---------------------------------------------------------------------//

// Objects & Properties

// var john = {
//     firstName: "John",
//     lastName: "Smith",
//     birthYear: 1990,
//     job: "Web Designer",
//     isMarried: false
// };

// // Get Property
// console.log(john.lastName);

// // Change Property
// john.job = "Programmer";

// ---------------------------------------------------------------------//

// Objects & Methods

// var john = {
//     firstName: "John",
//     lastName: "Smith",
//     birthYear: 1990,
//     job: "Web Designer",
//     isMarried: false,
//     family: ['Jane', 'Mark', 'Tom'],
//     age: function() {
//         return 2018 - this.birthYear;
//     }
// };

// console.log(john.age());

// ---------------------------------------------------------------------//

// For Loops

// // Syntax
// for (i = 0; i <= 10; i++) {
//     console.log(i);
// }

// var names = ["John", "Mike", "Tony", "Mary"];

// for (i = 0; i < names.length; i++) {
//     console.log(names[i]);
// }

// // Reverse For Loop
// for (i = names.length; i >= 0; i--) {
//     console.log(names[i]);
// }

// ---------------------------------------------------------------------//

// While Loops

// var names = ["John", "Mike", "Tony", "Mary"];
// var i = 0;

// while(i < names.length) {
//     console.log(names[i]);
//     i++;
// }

// ---------------------------------------------------------------------//