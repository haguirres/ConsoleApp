import { Component, OnInit, Input , Output, EventEmitter} from '@angular/core';
import { Iperson } from './model/iperson';
import { IAddress } from '../address/model/IAddress';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  @Input() personCh: Iperson;
  @Output() ShowAlert = new EventEmitter<boolean>();

  constructor() { }

  ngOnInit() {
  }

}
