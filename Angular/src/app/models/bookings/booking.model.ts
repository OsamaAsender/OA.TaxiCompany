import { Driver } from "../drivers/driver.model"

export interface Booking {
    id : number ,
    fromAddress : string,
    toAddress : string,
    pickUpTime : string,
    modelDate : number,
    price : number,
    driver : Driver,
    carPlateNumber : string 
} 