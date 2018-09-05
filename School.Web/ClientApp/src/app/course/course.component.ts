import { Component, OnInit } from '@angular/core';
import { ICourse } from './ICourse';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent implements OnInit {

  Course= <ICourse>{};

  constructor() { }

  ngOnInit() {
  }

  SaveCourse() {
    
  }

}
