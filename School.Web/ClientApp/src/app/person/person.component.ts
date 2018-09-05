import { Component, OnInit } from '@angular/core';
import { Iperson } from './model/iperson'

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  person = <Iperson>{};

  constructor() { }

  ngOnInit() {
  }

}
