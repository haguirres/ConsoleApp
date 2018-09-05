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

  Teacher = <ITeacher>{};
  Person = <Iperson>{};
  Address = <IAddress>{};
  constructor() { }

  ngOnInit() {
  }

  SaveTeacher() {
    alert("El RFC del maestro es: " + this.Teacher.RFC);
    
  }

}
