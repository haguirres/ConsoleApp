import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ISchool } from '../../school/model/ischool';
import { environment } from '../../../environments/environment';


@Injectable()
export class SchoolsHttpService {

  private schoolsApiUrl = environment.apiUrl + environment.apiSchoolsUrl.schools;
  private schoolApiUrl = environment.apiUrl + environment.apiSchoolsUrl.school;

  constructor(private httpclient: HttpClient)
  {}

  GetSchools()
  {
    return this.httpclient.get<ISchool[]>(this.schoolsApiUrl);
  }

  GetSchool(schoolId: string)
  {
    return this.httpclient.get<ISchool>(this.schoolApiUrl + '/' + schoolId);
  }

  PostSchool(school: ISchool)
  {
    return this.httpclient.post(this.schoolApiUrl, school);
  }

  UpdateSchool(school: ISchool) {
    return this.httpclient.put(this.schoolApiUrl, school);
  }

  DeleteSchool(schoolId: string) {
    return this.httpclient.delete(this.schoolApiUrl + '/' + schoolId);
  }
}
