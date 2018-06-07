// Coding Challenge 2

// 1. Create an array with some years where persons were born
// 2. Create an empty array (just [] )
// 3. Use a loop to fill the array with the ages of the persons
// 4. Use another loop to log into the console whether each person is of full age (18 or older), as well as their age

// 5. Finally, create a function called printFullAge which receives the array of years as an argument, executes the steps 2., 3. and 4. and returns an array of true/false boolean values: true if the person is of full age (>= 18 years) and false if not (< 18 years)
// 6. Call the function with two different arrays and store the results in two variables: full_1 and full_2

// Example input:  [1965, 2008, 1992]
// Example output: [true, false, true]

// Hint: you can use a loop not only to read from an array, like y[i], but also to set values in an array, like y[i] = ... You can also use the specific array methods.


// -------------------------------------------------------------------------------- //

// // Step 1
// var birthYears = [1964, 1978, 1994, 1996, 1942, 2006];

// // Step 2
// var ages = [];

// // Step 3
// for (i = 0; i < birthYears.length; i++) {
//     ages.push(2018 - birthYears[i]);
// }

// // Step 4
// for (i = 0; i < birthYears.length; i++) {
//     if (2018 - birthYears[i] <= 18) {
//         console.log("Subject " + (i + 1) + " is " + (2018 - birthYears[i]) + " years old, not full age.");
//     } else {
//         console.log("Subject " + (i + 1) + " is " + (2018 - birthYears[i]) + " years old, full age.");
//     }
// }

// // Step 5
// input_1 = [1920, 1974, 1954, 1987, 2010];
// input_2 = [1980, 1979, 1937, 2007, 2001, 1999];



// function printFullAge(years) {
//     var yearsOfBirth = [];
//     var output = [];

//     for (i = 0; i < years.length; i++) {
//         yearsOfBirth.push(years[i]);
//     }

//     for (i = 0; i < yearsOfBirth.length; i++) {
//         if (2018 - years[i] <= 18) {
//             output.push(false);
//         } else {
//             output.push(true);
//         } 
//     }

//     console.log(output);
// }

// // Step 6
// var full_1 = printFullAge(input_1);
// var full_2 = printFullAge(input_2);