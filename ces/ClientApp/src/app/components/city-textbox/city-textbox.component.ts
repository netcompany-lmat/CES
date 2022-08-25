import {Component, EventEmitter, Input, Output} from '@angular/core';
import {Observable, OperatorFunction} from 'rxjs';
import {debounceTime, distinctUntilChanged, map, filter} from 'rxjs/operators';
import { City } from 'src/app/interfaces/city';



@Component({
  selector: 'app-city-textbox',
  templateUrl: './city-textbox.component.html',
  styles: [`.form-control { background-color: unset !important; width: 300px; }`]
})
export class CityTextBox {
  @Input() displayText: string = "Choose city:";
  @Input() allCities: City[] = [];

  @Input() model?: City;
  @Output() modelChange = new EventEmitter<City>();

  formatter = (city: City) => city.name;

  search: OperatorFunction<string, readonly City[]> = (text$: Observable<string>) => text$.pipe(
    debounceTime(200),
    distinctUntilChanged(),
    filter(term => term.length >= 2),
    map(term => this.allCities.filter(city => new RegExp(term, 'mi').test(city.name)).slice(0, 10))
  );
}
