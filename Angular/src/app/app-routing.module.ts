import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { DriverComponent } from './driver/driver.component';
import { CarComponent } from './car/car.component';
import { CreateUpdateCarComponent } from './car/create-update-car/create-update-car.component';
import { CarDetailsComponent } from './car/cardetails/cardetails.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent,
  },
  {
    path: 'driver',
    component: DriverComponent,
  },
  {
    path: 'driver/add',
    component: DriverComponent,
  },
  {
    path: 'car',
    component: CarComponent,
  },
  {
    path: 'car/add',
    component: CreateUpdateCarComponent,
  },
  {
    path: 'car/edit/:id',
    component: CreateUpdateCarComponent,
  },
  {
    path: 'car/details/:id',
    component: CarDetailsComponent,
  },
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
