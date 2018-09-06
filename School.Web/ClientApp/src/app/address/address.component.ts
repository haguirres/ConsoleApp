import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { IAddress} from './model/index';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {
  //address = <IAddress>{};
  @Input() address: IAddress;
  @Output() ShowAlert = new EventEmitter<boolean>();

  constructor() { }

  ngOnInit() {
  }

  MostrarAlerta()
  {
    
    alert('Alerta del componente hijo');
    this.ShowAlert.emit(true);
  }

}
