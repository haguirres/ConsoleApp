import { Component, OnInit, Input , Output, EventEmitter} from '@angular/core';
import { Iperson } from './model/iperson';
import { IAddress } from '../../app/address/model/IAddress';


@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  @Input() person : Iperson;
  @Output() ShowAlert = new EventEmitter<boolean>();

  constructor() { }

  ngOnInit() {
    
  }

}
