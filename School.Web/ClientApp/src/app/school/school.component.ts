import { Component, OnInit } from '@angular/core';
import { IAddress, ISchool} from './model/index';
import { SchoolsHttpService } from '../services/http-services/schools-http.service';

@Component({
  selector: 'app-school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.css']
})

export class SchoolComponent implements OnInit{

  constructor(private schoolsHttpService: SchoolsHttpService) { }

  //isVisible: boolean = false;
  //idRol: number = 1;//1 - Estudiante y 2 -Maestro
  //direccion = <IAddress>{};
  //mostrarBoton: boolean = false;
  //school: ISchool;

  //schoolTypes: IschoolType[] = [
  //  { SchoolTypeId: 1, Type: 'Matutino' },
  //  { SchoolTypeId: 2, Type: 'Vespertino' },
  //  { SchoolTypeId: 3, Type: 'Mixto' }];
  //schoolTypeSelected = <IschoolType>{};

  //schools: ISchool[] = [
  //  { SchoolId: 1, SchoolName: 'Benito Juárez', IsActive: true, SchoolTypeName: 'Matutino', MinToPass: 8 },
  //  { SchoolId: 2, SchoolName: 'Porfirio Díaz', IsActive: true, SchoolTypeName: 'Matutino', MinToPass: 7 },
  //  { SchoolId: 3, SchoolName: 'Miguel Hidalgo', IsActive: false, SchoolTypeName: 'Vespertina', MinToPass: 5 }
  //];

  //@Output() eventoDireccion = new EventEmitter();

  GetSchool() {
    let schoolId = "1";
    this.schoolsHttpService.GetSchool(schoolId).subscribe(data => {
      console.log(data);
    });
  }

  GetSchools(){
    this.schoolsHttpService.GetSchools().subscribe(data => {
      console.log(data);
    });
  }

  PostSchool() {
    let newSchool = <ISchool>{
      SchoolId: 'B3',
      AddressId: 4,
      SchoolName: 'Sol',
      SchoolType: 1,
      MinToPass: 7,
      IsActive: true
    };

    this.schoolsHttpService.PostSchool(newSchool).subscribe(data => {
      console.log(data);
      alert('Escuela guardada');
    });
  }

  UpdateSchool() {
    let schoolId = '1';
    let updatedSchool = <ISchool>{
      SchoolId: '1',
      AddressId: 4,
      SchoolName: 'Escuela Actualizada',
      SchoolType: 1,
      MinToPass: 7,
      IsActive: true
    };

    this.schoolsHttpService.UpdateSchool(updatedSchool).subscribe(data => {
      console.log(data);
    });
  }

  DeleteSchool() {
    this.schoolsHttpService.DeleteSchool('1').subscribe(data => {
      alert('Esceual eliminada');
    });
  }

  ngOnInit() {
    //this.school.SchoolAddress = <IAddress>{};
  }

  ngAfterContentInit() {
  }

  //GuardarDatos() {
  //  //alert("Nombre de la escuela: " + this.school.SchoolName);
  //  this.isVisible = !this.isVisible;
  //  this.idRol = 2;
  //  console.log(this.schoolTypeSelected);
  //}

  //FiltrarEscuelas() {
  //  let escuelas = this.schools;
  //  this.schools = [];
  //  for (let escuela of escuelas) {
  //    if (escuela.IsActive) {
  //      this.schools.push(escuela);
  //    }
  //  }
  //}

  //ImprimirDireccion()
  //{
  //  this.school.SchoolType = this.schoolTypeSelected.SchoolTypeId;
  //  console.log(this.school);
  //}

  //AlertaPadre(propiedad:boolean)
  //{
  //  //this.mostrarBoton = propiedad;
  //  //console.log(propiedad);
  //  //alert('Alerta del componente padre');
  //  //this.eventoDireccion.emit();

  //  console.log(this.school);
  //  alert('Datos Guardados');
  //}
}
