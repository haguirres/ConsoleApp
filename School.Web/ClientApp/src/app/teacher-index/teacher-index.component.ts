import { Component, OnInit } from '@angular/core';
import { PERSONS } from '../mock-persons'
import { Iperson } from '../person/model/iperson';

@Component({
  selector: 'app-teacher-index',
  templateUrl: './teacher-index.component.html',
  styleUrls: ['./teacher-index.component.css']
})
export class TeacherIndexComponent implements OnInit {

  person: Iperson;
  persons = PERSONS;
  constructor() { }

  ngOnInit() {
  }

}
