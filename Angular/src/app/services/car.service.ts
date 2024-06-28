import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CarModel } from '../models/cars/car.model';
import { Observable } from 'rxjs';
import { CarDetails } from '../models/cars/car-details.model';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  constructor(private http: HttpClient) {}

  private carApiUrl: string = 'https://localhost:7297/api/Cars';

  getCars(): Observable<CarModel[]> {
    return this.http.get<CarModel[]>(`${this.carApiUrl}/GetCars`);
  }

  getCar(id: number): Observable<CarDetails> {
    return this.http.get<CarDetails>(`${this.carApiUrl}/GetCar/${id}`);
  }
}
