import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { IAddress } from './model/index';
import { ISchool } from '../school/model/ISchool';
import { IschoolType } from '../school-type/model/ischool-type';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {
  //address = <IAddress>{};
  @Input() address: IAddress;
  @Input() address2: IAddress;
  @Output() ShowAlert = new EventEmitter<boolean>();

  schoolTypes: IschoolType[] = [
    { SchoolTypeId: 1, Type: '14000'},
    { SchoolTypeId: 2, Type: '15000'},
    { SchoolTypeId: 3, Type: '16000'}];
  schoolTypeSelected = <IschoolType>{};

  constructor() { }

  ngOnInit() {
  }

  MostrarAlerta()
  {    
    //alert('Alerta del componente hijo');   
    
   //this.ShowAlert.emit(true);
    this.ShowAlert.emit(true);
  }


  IsVisibleSchool: boolean = false;
  IsVisibleTeacher: boolean = false;
  IsVisibleForm: boolean = false;

  schoolSelected = <ISchool>{};
  schools: ISchool[] =
    [
      { SchoolId: 1, SchoolName: "Escuela 1", SchoolTypeName: "Matutino", MinToPass: 8.0, SchoolIsActive: true },
      { SchoolId: 2, SchoolName: "Escuela 2", SchoolTypeName: "Matutino", MinToPass: 8.0, SchoolIsActive: true },
      { SchoolId: 3, SchoolName: "Escuela 3", SchoolTypeName: "Matutino", MinToPass: 8.0, SchoolIsActive: true },
      { SchoolId: 4, SchoolName: "Escuela 4", SchoolTypeName: "Matutino", MinToPass: 8.0, SchoolIsActive: true }
    ];

  year: number[] = [1, 2, 3, 4, 5, 6];
  yearSelected: number;


  SaveCourse() {
    console.log(this.schoolSelected);
    console.log(this.yearSelected);
  }

  SchoolSelect() {
    this.IsVisibleSchool = true;
  }
  TeacherSelect() {
    this.IsVisibleTeacher = true;
  }

  FormSelect() {
    this.IsVisibleForm = true;
  }


}
