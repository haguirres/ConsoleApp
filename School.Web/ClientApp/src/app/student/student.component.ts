import { Component, OnInit } from '@angular/core';
import { Istudent } from './model/istudent';
import { Iperson } from '../person/model/iperson';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  student = <Istudent>{};
  person_student = <Iperson>{}
  constructor() { }

  ngOnInit() {
  }

}
