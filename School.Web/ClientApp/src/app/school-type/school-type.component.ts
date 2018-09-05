import { Component, OnInit } from '@angular/core';
import { IschoolType } from './model/ischool-type'

@Component({
  selector: 'app-school-type',
  templateUrl: './school-type.component.html',
  styleUrls: ['./school-type.component.css']
})
export class SchoolTypeComponent implements OnInit {

  SchoolType = <IschoolType>{};
  Type: string;

  constructor() { }

  ngOnInit() {
  }

  SaveSchoolType() {
    alert("Tipo de escuela: " + this.SchoolType.Type);
  }

}
