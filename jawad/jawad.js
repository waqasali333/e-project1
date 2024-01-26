let No_of_cups=prompt("ENTER THE QUANTITY REQUIRED");
No_of_cups=Number.parseInt(No_of_cups)
switch(No_of_cups){
    case 10:
        console.log("10 cups are avalible")
        break;
        case 20:
            console.log("20 cups are avalible")
            break;
            case 35:
                console.log("35 cups are avalible")
                break;
                default:
                    console.log("this quantity of cups are not avalible")

}

for (let index=1; index<=10;index++){
    if(index==5){
        console.log("5 is found")
        continue
    }
    console.log("value of i is",index)
}