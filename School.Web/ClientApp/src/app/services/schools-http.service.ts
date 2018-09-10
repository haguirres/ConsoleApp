import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ISchool } from '../school/model/ischool';


@Injectable()
export class SchoolsHttpService {

  private urlSchoolService = 'http://localhost:38237/schools';

  SchoolName = 'hola';

  constructor(private httpclient: HttpClient)
  {}

  GetSchools() {
    return this.httpclient.get<ISchool[]>(this.urlSchoolService);
  }

}
