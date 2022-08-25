import {Component, Input} from '@angular/core';

@Component({
  selector: 'app-routes-table',
  templateUrl: './routes-table.component.html'
})
export class RoutesTable {
  @Input() isCollapsed = true;

  public readonly telstarDealOption = 'Telstar Logistics Deal';

  routes = [
    {
      option: this.telstarDealOption,
      price: 250,
      time: 42069
    },
    {
      option: 'Speed',
      price: 399.99,
      time: 300
    },
    {
      option: 'Economy',
      price: 300,
      time: 3600
    },
  ];

  minutesToString(minutes: number) {
    // calculate (and subtract) whole days
    var days = Math.floor(minutes / 1440);
    minutes -= days * 1440;

    // calculate (and subtract) whole hours
    var hours = Math.floor(minutes / 60) % 24;
    minutes -= hours * 60;

    // calculate (and subtract) whole minutes
    var minutes = Math.floor(minutes) % 60;

    return days + ' days, ' + hours + ':' + this.addLeadingZeros(minutes, 2);
  };

  private addLeadingZeros(num: number, totalLength: number): string {
    return String(num).padStart(totalLength, '0');
  }
}
