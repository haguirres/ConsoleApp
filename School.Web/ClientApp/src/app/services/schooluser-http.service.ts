import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IschoolUser } from '../school-user/model/ischool-user';


@Injectable()
export class SchooluserHttpService {

  private schoolUserUrl = 'http://localhost:38237/api/school-user';  // URL to web api

  constructor(private http: HttpClient) { }

  GetSchoolUser() {
    return this.http.get<IschoolUser[]>(this.schoolUserUrl);
  }

  PostSchoolUser(schoolUser: IschoolUser) {
    return this.http.post(this.schoolUserUrl, schoolUser);
  }

  UpdateSchoolUser(schoolUser: IschoolUser) {
    return this.http.put(this.schoolUserUrl, schoolUser);
  }

  DeleteSchoolUser(schoolUser: IschoolUser) {
    return this.http.delete(this.schoolUserUrl);
  }
}
