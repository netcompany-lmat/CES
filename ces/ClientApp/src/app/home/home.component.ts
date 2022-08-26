import { Component } from '@angular/core';
import { City } from '../interfaces/city';
import { EstimateRoutesRequest } from '../services/estimate-routes/estimate-routes.request';
import { EstimateRoutesResponse } from '../services/estimate-routes/estimate-routes.response';
import { EstimateRoutesService } from '../services/estimate-routes/estimate-routes.service';
import { ToastService } from '../services/toast/toast.service';
import { WebApiService } from '../services/web-api/web-api.service';
import { cities } from './temp-data'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  constructor(
    private webApi: WebApiService,
    private estimateRoutesService: EstimateRoutesService,
    private toastService: ToastService
  ) {}

  allCities = cities;

  fromCity?: City;
  toCity?: City;

  fromText = "From:";
  toText = "To:";
  weight = 0;
  dimX = 0;
  dimY = 0;
  dimZ = 0;
  type = "Standard";

  selectedRoutesCollapsed = true;
  routes: EstimateRoutesResponse = {routes: []};

  estimateClicked(): void {
    let failed = false;

    if (this.fromCity == null || this.fromCity?.name == "") {
      this.showWarning('Incorrect start city name!');
      failed = true;
    }

    if (this.toCity == null || this.toCity?.name == "") {
      this.showWarning('Incorrect destination city name!');
      failed = true;
    }
    if (this.weight <= 0) {
      this.showWarning('Incorrect weight!');
      failed = true;
    }
    if (this.dimX <= 0) {
      this.showWarning('Incorrect width!');
      failed = true;
    }
    if (this.dimY <= 0) {
      this.showWarning('Incorrect height!');
      failed = true;
    }
    if (this.dimZ <= 0) {
      this.showWarning('Incorrect depth!');
      failed = true;
    }

    console.log('fromCity:', this.fromCity);
    console.log('toCity:', this.toCity);
    console.log('weight:', this.weight);
    console.log('dimX:', this.dimX);
    console.log('dimY:', this.dimY);
    console.log('dimZ:', this.dimZ);
    console.log('type:', this.type);
    console.log('================================');

    if (failed) {
      return;
    }

    const data: EstimateRoutesRequest = {
      startCity: this.fromCity!.name,
      destinationCity: this.toCity!.name,
      dimX: this.dimX,
      dimY: this.dimY,
      dimZ: this.dimZ,
      weight: this.weight,
      type: this.type
    }

    this.routes = this.estimateRoutesService.estimateRoutes(data);
    setTimeout(() => this.selectedRoutesCollapsed = false, 1000);
  }

  typeSelected(type: string): void {
    console.log('GOT ASS', type);
    this.type = type;
  }

  private showWarning(msg: string) {
    this.toastService.show(msg);
  }
}
