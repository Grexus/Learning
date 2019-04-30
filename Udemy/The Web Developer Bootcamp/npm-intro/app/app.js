var catMe = require("cat-me");
var knockKnockJoke = require("knock-knock-jokes");
var faker = require("faker");

console.log(catMe());
console.log(knockKnockJoke());

for (i = 0; i < 10; i++) {
    let product = faker.commerce.productName();
    let price = faker.commerce.price();

    console.log(product + ' - $' + price)
}