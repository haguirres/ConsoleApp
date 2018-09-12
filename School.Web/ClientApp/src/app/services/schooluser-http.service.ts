import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IschoolUser } from '../school-user/model/ischool-user';
import { Observable } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()
export class SchooluserHttpService {

  private schoolUserUrl = 'http://localhost:38237/api/school-user';  // URL to web api

  constructor(private http: HttpClient) { }

  GetSchoolUsers() {
    return this.http.get<IschoolUser[]>(this.schoolUserUrl);
  }

  GetSchoolUser(SchoolUserId: number) {
    const url = `${this.schoolUserUrl}/${SchoolUserId}`;
    return this.http.get<IschoolUser>(url)
  }

  UpdateSchoolUser(schoolUser: IschoolUser) {
    return this.http.put(this.schoolUserUrl, schoolUser);
  }

  DeleteSchoolUser(SchoolUserId: number) {
    const url = `${this.schoolUserUrl}/${SchoolUserId}`;
    return this.http.delete(url);
  }

  addschoolUser(schoolUser: IschoolUser): Observable<IschoolUser> {
    return this.http.post<IschoolUser>(this.schoolUserUrl, schoolUser, httpOptions);
    
  }
  PostSchoolUser(schoolUser: IschoolUser) {
    return this.http.post(this.schoolUserUrl, schoolUser);
  }
}
