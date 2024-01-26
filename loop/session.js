let countdown = prompt("enter any numberfor reverse counting");
countdown=Number.parseInt(countdown)

while (countdown > 0) {
    console.log("countdown: " + countdown);
    countdown--;
}
console.log("liftofff!");

//example 2: user input validation
let userInput;
while (userInput !=="exit"){
    userInput = prompt("Enter a value (type 'exit' to end):");

    console.log("you entered: "+ userInput);
}
console.log("program ended.");

//exemple 3: summing up numbers entered by the user
let sum = 0;
let number;
while (true) {
    number =parseInt(prompt("enter a number(or 0 to finish):"));

    if (number=== 0){
        break; //exit the lopp if user enter 0
    }
    sum += number;
}
console.log("sum of entered numbers:"+sum);

