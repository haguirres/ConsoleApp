import { Component, OnInit, Input } from '@angular/core';
import { Istudent } from './model/istudent';
import { Iperson } from '../person/model/iperson';
import { IAddress } from '../address/model/index';


@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  student = <Istudent>{};
  //person = <Iperson>{};
 // address = <IAddress>{};

  constructor() { }

  ngOnInit() {
     this.student.student_address = <IAddress>{}; //Falta que pase los datos del componete Address
    //this.person.PersonAddress = <IAddress>{} 
    this.student.student_person = <Iperson>{};
  }

  SaveStudentData() {
    alert("Sirve " + this.student.Account + " " + this.student.student_person.CURP + "" + this.student.student_address.Address);
  }

}
