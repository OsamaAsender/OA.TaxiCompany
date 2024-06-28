import { Component, OnInit } from '@angular/core';
import { CarService } from '../../services/car.service';

@Component({
  selector: 'app-cardetails',
  templateUrl: './cardetails.component.html',
  styleUrl: './cardetails.component.css'
})
export class CarDetailsComponent implements OnInit {

  constructor(private carSvc : CarService) {}

  ngOnInit(): void {
    next: 
  }

}
