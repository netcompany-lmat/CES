import { Inject, Injectable, InjectionToken, Optional } from "@angular/core";
import { Location } from '@angular/common';
import { HttpClient, HttpHeaders } from "@angular/common/http";

export const API_BASE_URL = new InjectionToken<string>('API_BASE_URL');

@Injectable({
  providedIn: 'root',
})
export class WebApiService {
  locationPath?: string;
  forecasts: any;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  shit(): void {
    const content_ = JSON.stringify({ Id: 321434});

    let options_ : any = {
        body: content_,
        observe: "response",
        responseType: "blob",
        headers: new HttpHeaders({
            "Content-Type": "application/json",
        })
    };

    this.http.post<any[]>(
      this.baseUrl
      + 'Order/InsertOrder', options_).subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}