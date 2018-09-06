import { Component, OnInit } from '@angular/core';
import {Iroles } from './Models/Iroles';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.css']
})
export class RolesComponent implements OnInit {

  roles = <Iroles>{};
  constructor() { }

  ngOnInit() {
  }

}
