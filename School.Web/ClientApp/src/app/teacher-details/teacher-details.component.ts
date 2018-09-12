import { Component, OnInit } from '@angular/core';
import { ITeacher } from '../teacher/model/iteacher';
import { TeacherService } from '../services/teacher.service'
import { Location } from '@angular/common';
import { Iperson } from '../person/model/iperson';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-teacher-details',
  templateUrl: './teacher-details.component.html',
  styleUrls: ['./teacher-details.component.css']
})
export class TeacherDetailsComponent implements OnInit {

  teacher: ITeacher;

  Teacher = <ITeacher>{
    Person: { PersonId: 1, PersonFirstName: "Juan", PersonLastName: "Espinosa", PersonAge: 25, CURP: "EIOJ921027HMCSRN02", Email: "dasdas@hdada.com", Phone: 151988, address: { Street: "Calle 2", ExtNumber: "23", IntNumber: "", ZipCode: 14700 }, },

    RFC: "EIOJ921027RRR"
  };
  constructor(private route: ActivatedRoute,
    private teacherService: TeacherService,
    private location: Location) { }

  ngOnInit() {
  }

  goBack(): void {
    this.location.back();
  }

  save(): void {
    this.teacherService.updateTeacher(this.teacher)
      .subscribe(() => this.goBack());
  }

}
