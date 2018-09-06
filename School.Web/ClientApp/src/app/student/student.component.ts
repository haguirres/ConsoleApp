import { Component, OnInit } from '@angular/core';
import { Istudent } from './model/istudent';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  student = <Istudent>{};


  constructor() { }

  ngOnInit() {
  }

}
