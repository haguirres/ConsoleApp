import { Component, OnInit } from '@angular/core';
import { PERSONS } from '../mock-persons'
import { TeacherService } from '../services/teacher.service'
import { Iperson } from '../person/model/iperson';
import { ITeacher } from '../teacher/model/iteacher';

@Component({
  selector: 'app-teacher-index',
  templateUrl: './teacher-index.component.html',
  styleUrls: ['./teacher-index.component.css']
})
export class TeacherIndexComponent implements OnInit {

  teacher: ITeacher;
  teachers: ITeacher[];
  

  constructor(private teacherService: TeacherService) { }

  ngOnInit() {
    this.getTeachers();
  }

  getTeachers(): void {
    this.teacherService.getTeachers()
      .subscribe(teachers => this.teachers = this.teachers);
  }

}
