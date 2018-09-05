import { Component, OnInit } from '@angular/core';
import { Icourse } from './model/icourse';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent implements OnInit {

  course= <Icourse>{};

  constructor() { }

  ngOnInit() {
  }

  SaveCourse() {
    
  }

}
