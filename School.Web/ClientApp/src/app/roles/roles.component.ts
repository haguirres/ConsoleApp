import { Component, OnInit } from '@angular/core';
import {Iroles } from './Models/Iroles';
import { ApplicationDataServiceService } from '../services/application-data-service.service';
@Component({

  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.css']
})
export class RolesComponent implements OnInit {

  roles = <Iroles>{};
  constructor(private applicationDataService: ApplicationDataServiceService) {
    console.log(applicationDataService);
  }

  ngOnInit() {
  }

}
