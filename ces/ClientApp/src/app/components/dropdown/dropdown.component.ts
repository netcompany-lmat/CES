import {Component, EventEmitter, Output} from '@angular/core';

@Component({
  selector: 'app-dropdown',
  templateUrl: './dropdown.component.html'
})
export class Dropdown {
  @Output() selectedItemEvent = new EventEmitter<string>();
  _model = "Standard";

  get model() : string {
    return this._model;
  }
  set model(value: string) {
    this._model = value;
    this.selectedItemEvent.emit(value);
  }


  private _options = [
    {
      id: "Standard",
      label: "Standard"
    },
    {
      id: "RecordedDelivery",
      label: "Confirmed package"
    },
    {
      id: "LiveAnimals",
      label: "Live animals"
    },
    {
      id: "CautiousParcels",
      label: "Cautious parcels"
    },
    {
      id: "RefrigeratedGoods",
      label: "Refrigerated goods"
    },
  ];
  public get options() {
    return this._options;
  }
  public set options(value) {
    this._options = value;
  }
}
