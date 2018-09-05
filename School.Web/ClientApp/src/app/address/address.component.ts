import { Component, OnInit } from '@angular/core';
import { IAddress} from './model/index';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {
  address = <IAddress>{};

  constructor() { }

  ngOnInit() {
  }



}
