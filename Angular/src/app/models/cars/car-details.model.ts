import { Booking } from '../bookings/booking.model';

export interface CarDetails {
  id: number;
  platenumber: string;
  model: string;
  modelDate: number;
  powerType: number;
  driverFullName: string;
  bookings: Booking[]; //custom Object
}
