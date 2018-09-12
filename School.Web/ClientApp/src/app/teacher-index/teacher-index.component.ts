import { Component, OnInit } from '@angular/core';
import { PERSONS } from '../mock-persons'
import { TeacherService } from '../services/teacher.service'
import { Iperson } from '../person/model/iperson';
import { ITeacher } from '../teacher/model/iteacher';
import { ApplicationDataServiceService } from '../services/index';

@Component({
  selector: 'app-teacher-index',
  templateUrl: './teacher-index.component.html',
  styleUrls: ['./teacher-index.component.css']
})
export class TeacherIndexComponent implements OnInit {

  teacher: ITeacher;
  teacherArray: ITeacher[] = [];
  

  constructor(private applicationDataService: ApplicationDataServiceService,
    private teacherService: TeacherService) {
    console.log(applicationDataService);
  }

  ngOnInit() {
    this.teacherService.getTeachers().subscribe(data => {
      this.teacherArray = data;
      console.log(data);
      
    });
  }

  Delete(teacherId: number) {
    this.teacherService.DeleteTeacher(teacherId).subscribe(data => {
      console.log(data);
      alert("Profesor eliminado correctamente");
      this.ngOnInit();
    });
  }

}
