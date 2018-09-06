import { Component, OnInit, AfterContentInit, Output, EventEmitter } from '@angular/core';
import { ISchool } from './model/ISchool';
import { IschoolType } from '../school-type/model/ischool-type';
import { IAddress } from '../address/model/index';

@Component({
  selector: 'app-school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.css']
})
export class SchoolComponent implements OnInit, AfterContentInit {
  date: Date = new Date();
  school = <ISchool>{};
  schoolTypes: IschoolType[] = [
    { SchoolTypeId: 1, Type: 'Matutino' },
    { SchoolTypeId: 2, Type: 'Vespertino' },
    { SchoolTypeId: 3, Type: 'Mixto' }];
  schoolTypeSelected = <IschoolType>{};

  isVisible: boolean = false;
  idRol: number = 1;//1 - Estudiante y 2 -Maestro

  schools: ISchool[] = [
    { SchoolId: 1, SchoolName: 'Benito Juárez', SchoolIsActive: true, SchoolTypeName: 'Matutino', MinToPass: 8 },
    { SchoolId: 2, SchoolName: 'Porfirio Díaz', SchoolIsActive: true, SchoolTypeName: 'Matutino', MinToPass: 7 },
    { SchoolId: 3, SchoolName: 'Miguel Hidalgo', SchoolIsActive: false, SchoolTypeName: 'Vespertina', MinToPass: 5 }
  ];

  direccion = <IAddress>{};
  mostrarBoton: boolean = false;

  @Output() eventoDireccion = new EventEmitter();
  constructor() { }

  ngOnInit() {
    this.school.SchoolAddress = <IAddress>{};
  }

  ngAfterContentInit() {
    console.log(this.date);
  }

  GuardarDatos() {
    //alert("Nombre de la escuela: " + this.school.SchoolName);
    this.isVisible = !this.isVisible;
    this.idRol = 2;
    console.log(this.schoolTypeSelected);
  }

  FiltrarEscuelas() {
    let escuelas = this.schools;
    this.schools = [];
    for (let escuela of escuelas) {
      if (escuela.SchoolIsActive) {
        this.schools.push(escuela);
      }
    }
  }

  ImprimirDireccion()
  {
    this.school.SchoolTypeId = this.schoolTypeSelected.SchoolTypeId;
    console.log(this.school);
  }

  AlertaPadre(propiedad:boolean)
  {
    this.mostrarBoton = propiedad;
    console.log(propiedad);
    alert('Alerta del componente padre');
    this.eventoDireccion.emit();
  }
}
