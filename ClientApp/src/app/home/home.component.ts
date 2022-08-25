import { Component } from '@angular/core';
import { City } from '../interfaces/city';
import { cities } from './temp-data'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  allCities = cities;

  fromCity?: City;
  toCity?: City;

  fromText = "From:";
  toText = "To:";
}
