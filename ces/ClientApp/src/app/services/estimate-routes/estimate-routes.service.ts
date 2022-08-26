import { Injectable } from "@angular/core";
import { EstimateRoutesRequest } from "./estimate-routes.request";
import { EstimateRoutesResponse } from "./estimate-routes.response";

@Injectable({
  providedIn: 'root',
})
export class EstimateRoutesService {
  estimateRoutes(request: EstimateRoutesRequest) {
    // TODO KULA mockup
    const x: EstimateRoutesResponse = {
      routes: [
        {
          uniqueID: 3,
          option: 'Telstar Logistics Deal',
          price: 30,
          time: 3000
        },
        {
          uniqueID: 3432,
          option: 'Fastest',
          price: 320,
          time: 300
        },
        {
          uniqueID: 34908,
          option: 'Shortest',
          price: 60,
          time: 8000
        },
      ]
    }
    return x;
  }
}
