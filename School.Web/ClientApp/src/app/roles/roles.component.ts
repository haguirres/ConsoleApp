import { Component, OnInit } from '@angular/core';
import { RolesHttpService } from '../services/http-services/roles-http.service'
import { Iroles } from '../roles/Models/Iroles';
import { ApplicationDataServiceService, SchoolHttpService } from '../services/index';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.css']
})

export class RolesComponent implements OnInit {
  roles = <Iroles>{};
  rolesArray: Iroles[] = [];

  constructor(private applicationDataService: ApplicationDataServiceService,
    private schoolHttpService: SchoolHttpService, private rolesHttpService: RolesHttpService) {
    console.log(applicationDataService);
  }

  ngOnInit() {
  }
  ObtenerRoles() {
    this.schoolHttpService.GetRoles().subscribe(data => {
      this.rolesArray = data;
      console.log(data);
    });
  }

  GetRol() {
    let rolId = 2;

    this.rolesHttpService.GetRol(rolId).subscribe(data => {
      console.log(data);
    });

  }
  GetRoles() {
    this.rolesHttpService.GetRoles().subscribe(data => {
      console.log(data);
    });

  }
  PostRol() {
    let newRole = <Iroles>{
      IsActive: true,
      Name: 'Semillero'
    };

    this.rolesHttpService.PostRol(newRole).subscribe(data => {
      console.log(data);
      alert('Rol guardado');
    });

  }
  UpdateRol() {
    let rolId = 4;
    let updatedRol = <Iroles>{
      IsActive: true,
      Name: 'Administrador'
    };

    this.rolesHttpService.UpdateRoles(rolId, updatedRol).subscribe(data => {
      console.log(data);
    });
  }
  DeleteRol() {
    this.rolesHttpService.DeleteRol(5).subscribe(data => {
      alert('El rol fue eliminado');
    });
  }
}
