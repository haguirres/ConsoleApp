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
  personFt = <Iperson>{};

  constructor() { }

  ngOnInit() {
    this.student.student_person = <Iperson>{};
  }

  SaveStudentData() {
    alert("Sirve " + this.student.Account + " " + this.student.student_person.PersonAge);
  }

}
