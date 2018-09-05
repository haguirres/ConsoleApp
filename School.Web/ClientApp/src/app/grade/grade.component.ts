import { Component, OnInit } from '@angular/core';
import { Igrade } from './model/igrade';

@Component({
  selector: 'app-grade',
  templateUrl: './grade.component.html',
  styleUrls: ['./grade.component.css']
})
export class GradeComponent implements OnInit {

  grade = <Igrade>{};

  constructor() { }

  ngOnInit() {
  }

}
