import { Component, OnInit, Input , Output, EventEmitter} from '@angular/core';
import { Iperson } from './model/iperson';
import { IAddress } from '../address/model/IAddress';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {
  //person = <Iperson>{};
  @Input() person: Iperson;

  constructor() { }

  ngOnInit() {
    this.person.PersonAddress = <IAddress>{};
  }

  ////prueba1
  //SaveStudentData() {
  //  alert("Sirve " + this.person.PersonAddress.Address + " " + "direccion persona");
  //}

}
