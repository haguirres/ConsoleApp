import { Component, OnInit } from '@angular/core';
import { Iroles } from './Models/Iroles';
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
    private schoolHttpService: SchoolHttpService) {
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
}
