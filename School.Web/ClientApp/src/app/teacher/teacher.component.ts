import { Component, OnInit } from '@angular/core';
import { ITeacher } from './model/iteacher';
@Component({
  selector: 'app-teacher',
  templateUrl: './teacher.component.html',
  styleUrls: ['./teacher.component.css']
})
export class TeacherComponent implements OnInit {

  Teacher = <ITeacher>{};

  constructor() { }

  ngOnInit() {
  }

  SaveTeacher() {
    alert("El RFC del maestro es: " + this.Teacher.RFC);

  }

}
