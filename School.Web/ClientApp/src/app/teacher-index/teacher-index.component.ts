import { Component, OnInit } from '@angular/core';
import { PERSONS } from '../mock-persons'
import { TeacherService } from '../services/teacher.service'
import { Iperson } from '../person/model/iperson';

@Component({
  selector: 'app-teacher-index',
  templateUrl: './teacher-index.component.html',
  styleUrls: ['./teacher-index.component.css']
})
export class TeacherIndexComponent implements OnInit {

  person: Iperson;
  persons: Iperson[];
  

  constructor(private teacherService: TeacherService) { }

  ngOnInit() {
    this.getPersons();
  }

  getPersons(): void {
    this.teacherService.getPersons()
      .subscribe(persons => this.persons = persons);
  }

}
