import { Component, OnInit } from '@angular/core';
import { ISchool } from '../school/model/index';
import { SchoolsHttpService } from '../services/http-services/schools-http.service';

@Component({
  selector: 'app-school-index',
  templateUrl: './school-index.component.html',
  styleUrls: ['./school-index.component.css']
})
export class SchoolIndexComponent implements OnInit {

  school: ISchool;
  schoolsArray: ISchool[] = [];

  constructor(private schoolsHttpService: SchoolsHttpService) { }

  ngOnInit() {
    this.schoolsHttpService.GetSchools().subscribe(data => {
      this.schoolsArray = data;
      console.log(data);

    });
  }

  DeleteSchool(schoolId: string) {
    this.schoolsHttpService.DeleteSchool(schoolId).subscribe(data => {
      alert('Se ha eliminado la escuela correctamente');
      this.ngOnInit();
    }); 
  }
}
