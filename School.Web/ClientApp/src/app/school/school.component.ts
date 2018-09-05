import { Component, OnInit, AfterContentInit } from '@angular/core';
import { IAddress, ISchool } from './model/index';

@Component({
  selector: 'app-school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.css']
})
export class SchoolComponent implements OnInit, AfterContentInit
{
  date: Date = new Date();
  school = <ISchool>{};
  address = <IAddress>{};

  constructor() { }

  ngOnInit() {
  }

  ngAfterContentInit() {
    console.log(this.date);
  }

  GuardarDatos() {
    alert("Nombre de la escuela: " + this.school.SchoolName);    
  }
}
