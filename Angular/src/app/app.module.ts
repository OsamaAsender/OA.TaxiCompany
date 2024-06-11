import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { DriverComponent } from './driver/driver.component';
import { CarComponent } from './car/car.component';

import {MatButtonModule} from '@angular/material/button';

import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { CreateUpdateCarComponent } from './car/create-update-car/create-update-car.component';
import { HttpClientModule, provideHttpClient } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    DriverComponent,
    CarComponent,
    CreateUpdateCarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatButtonModule,
    HttpClientModule
  ],
  providers: [
    provideAnimationsAsync(),
    provideHttpClient()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
