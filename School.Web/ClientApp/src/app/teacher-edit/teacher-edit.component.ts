import { Component, OnInit } from '@angular/core';
import { ITeacher } from '../teacher/model/iteacher';
import { Iperson } from '../person/model/iperson';
import { IAddress } from '../address/model/IAddress';

@Component({
  selector: 'app-teacher-edit',
  templateUrl: './teacher-edit.component.html',
  styleUrls: ['./teacher-edit.component.css']
})
export class TeacherEditComponent implements OnInit {


  Teacher = <ITeacher>{
    Person: { PersonId: 1, PersonName: "Juan", PersonAge: 25, CURP: "EIOJ921027HMCSRN02", Email: "dasdas@hdada.com", Phone: 151988, address: { Address: "Calle 2", ExtNumber: "23", IntNumber: "", ZipCode: 14700 }, },
   
     RFC: "EIOJ921027RRR"
  };
  constructor() { }

  ngOnInit() {

  }

}
