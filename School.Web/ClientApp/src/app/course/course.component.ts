import { Component, OnInit } from '@angular/core';
import { Icourse } from './model/icourse';
import { Isignature } from '../signature/model/isignature';
import { ISchool } from '../school/model/ISchool';
import { ITeacher } from '../teacher/model/iteacher';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent implements OnInit {
  IsVisibleSchool: boolean = false;
  IsVisibleTeacher: boolean = false;
  IsVisibleForm: boolean = false;
  course = <Icourse>{};
  signatureSelected = <Isignature>{};
  signatures: Isignature[] = [
    { SignaturesId: 1, SignaturesName: "Español", IsActive: false },
    { SignaturesId: 2, SignaturesName: "Matemáticas", IsActive: false },
    { SignaturesId: 3, SignaturesName: "Física", IsActive: false },
    { SignaturesId: 4, SignaturesName: "Quimica", IsActive: false }
  ];
  schoolSelected = <ISchool>{};
  //schools: ISchool[] =
  //  [
  //    { SchoolId: "1", SchoolName: "Escuela 1", SchoolType: 1, MinToPass: 8.0, IsActive: true },
  //    { SchoolId: '2', SchoolName: "Escuela 2", SchoolType: 1, MinToPass: 8.0, IsActive: true },
  //    { SchoolId: '3', SchoolName: "Escuela 3", SchoolType: 1, MinToPass: 8.0, IsActive: true },
  //    { SchoolId: '4', SchoolName: "Escuela 4", SchoolType: 2, MinToPass: 8.0, IsActive: true }
  //  ];

  teacherSelected = <ITeacher>{};
  teachers: ITeacher[] =
    [
      { PersonId: 1, TeacherId: 1, RFC: "Iovany", IsActive: true },
      { PersonId: 1, TeacherId: 2, RFC: "Sebas", IsActive: true },
      { PersonId: 1, TeacherId: 3, RFC: "Juan", IsActive: true },
      { PersonId: 1, TeacherId: 4, RFC: "Viridiana", IsActive: true }
    ];

  year: number[] = [1, 2, 3, 4, 5, 6];
  yearSelected: number;
  constructor() { }

  ngOnInit() {
  }

  SaveCourse() {
    console.log(this.schoolSelected);
    console.log(this.teacherSelected);
    console.log(this.signatureSelected);
    console.log(this.yearSelected);
  }

  SchoolSelect() {
    this.IsVisibleSchool = true;
  }
  TeacherSelect() {
    this.IsVisibleTeacher = true;
  }

  FormSelect() {
    this.IsVisibleForm = true;
  }
}
