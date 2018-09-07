import { Component, OnInit } from '@angular/core';
import { Istudent } from './model/istudent';
import { Iperson } from '../person/model/iperson';
import { IAddress } from '../address/model/IAddress';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  student = <Istudent>{};


  constructor() { }

  ngOnInit() {
    this.student.StudentPerson = <Iperson>{};
    this.student.StudentAddress = <IAddress>{};
  }

  SaveStudentData() {
    alert(this.student.Account + " " + this.student.StudentPerson.PersonAge + " " + this.student.StudentAddress.Address);
  }

}
