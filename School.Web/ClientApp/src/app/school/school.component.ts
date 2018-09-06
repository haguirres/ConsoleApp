import { Component, OnInit, AfterContentInit } from '@angular/core';
import { ISchool } from './model/ISchool';
 
@Component({
  selector: 'app-school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.css'] 
})
export class SchoolComponent implements OnInit, AfterContentInit
{
  date: Date = new Date();
  school = <ISchool>{};

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
