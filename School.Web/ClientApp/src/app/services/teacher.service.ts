import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ITeacher } from '../teacher/model/iteacher'

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()


export class TeacherService {

  private teachersUrl = 'http://localhost:38237/api/teacher';  // URL to web api

  constructor(private http: HttpClient) { }

  getTeachers(): Observable<ITeacher[]> {
    return this.http.get<ITeacher[]>(this.teachersUrl);
  }

  getTeacher(TeacherId: number): Observable<ITeacher> {
    const url = `${this.teachersUrl}/${TeacherId}`;
    return this.http.get<ITeacher>(url)
  }

  updateTeacher(teacher: ITeacher): Observable<any> {
    return this.http.put(this.teachersUrl, teacher, httpOptions)
  }

  addTeacher(teacher: ITeacher): Observable<ITeacher> {
    return this.http.post<ITeacher>(this.teachersUrl, teacher, httpOptions)
  }

  deleteTeacher(teacher: ITeacher | number): Observable<ITeacher> {
    const TeacherId = typeof teacher === 'number' ? teacher : teacher.TeacherId;
    const url = `${this.teachersUrl}/${TeacherId}`;

    return this.http.delete<ITeacher>(url, httpOptions)

  }
}
