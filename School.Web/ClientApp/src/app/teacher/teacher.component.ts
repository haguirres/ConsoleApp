import { Component, OnInit } from '@angular/core';
import { ITeacher } from './model/iteacher';
import { Iperson } from '../person/model/iperson';
import { IAddress} from '../address/model/IAddress';

@Component({
  selector: 'app-teacher',
  templateUrl: './teacher.component.html',
  styleUrls: ['./teacher.component.css']
})
export class TeacherComponent implements OnInit {

  Teacher = <ITeacher>{
    //Person: { PersonName: "Juan", PersonAge: 25, CURP: "EIOJ921027HMCSRN02", Email: "dasdas@hdada.com", Phone:151988 },
    //Address: { Address: "Calle 2", ExtNumber: "23", IntNumber: "", ZipCode: 14700 },
   // RFC: "EIOJ921027RRR"
  };


  constructor() { }

  ngOnInit() {
    
    this.Teacher.Person = <Iperson>{};
    this.Teacher.Person.address = <IAddress>{};

  }

  SaveTeacher() {
    alert("El RFC del maestro es: " + this.Teacher.RFC);
    console.log(this.Teacher)
  }

}
