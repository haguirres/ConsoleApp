import { Injectable } from '@angular/core';
import { Iperson } from '../person/model/iperson'
import { PERSONS } from '../mock-persons'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()


export class TeacherService {

  private teachersUrl = 'http://localhost:38237/api/teacher';  // URL to web api

  constructor(private http: HttpClient) { }

  getPersons(): Observable<Iperson[]> {
    return this.http.get<Iperson[]>(this.teachersUrl);
  }

  getPerson(PersonId: number): Observable<Iperson> {
    const url = `${this.teachersUrl}/${PersonId}`;
    return this.http.get<Iperson>(url)
  }

  updateTeacher(person: Iperson): Observable<any> {
    return this.http.put(this.teachersUrl, person, httpOptions)
  }

}
