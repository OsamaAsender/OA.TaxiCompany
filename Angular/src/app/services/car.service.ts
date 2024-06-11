import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CarModel } from '../models/cars/car.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  constructor(private http : HttpClient) { }

  getCars() : Observable<CarModel[]> {

    return this.http.get<CarModel[]>("https://localhost:7297/api/Cars/GetCars");
   } 
}