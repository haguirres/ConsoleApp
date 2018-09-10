import { Component, OnInit } from '@angular/core';
import { ITeacher } from '../teacher/model/iteacher';

@Component({
  selector: 'app-teacher-details',
  templateUrl: './teacher-details.component.html',
  styleUrls: ['./teacher-details.component.css']
})
export class TeacherDetailsComponent implements OnInit {

  Teacher = <ITeacher>{
    Person: { PersonId: 1, PersonFirstName: "Juan", PersonLastName: "Espinosa", PersonAge: 25, CURP: "EIOJ921027HMCSRN02", Email: "dasdas@hdada.com", Phone: 151988, address: { Address: "Calle 2", ExtNumber: "23", IntNumber: "", ZipCode: 14700 }, },

    RFC: "EIOJ921027RRR"
  };
  constructor() { }

  ngOnInit() {
  }

}
