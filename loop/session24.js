let student={
 "jawad":50,
"shah":40,
"ali":45

}

for (let i in student){
    console.log(i,student[i])
}

function hello(fname, lname, greet){
    console.log("hello"+""+fname+""+lname+""+"lets learn coding!")
}
hello("jawad","shah")