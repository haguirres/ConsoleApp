import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Iroles } from '../roles/Models/Iroles';

@Injectable()
export class SchoolHttpService {
  private rolesUrlService = 'http://localhost:38237/api/catalogs/roles';
  constructor(private httpClient: HttpClient) { }

  GetRoles()
  {
    return this.httpClient.get<Iroles[]>(this.rolesUrlService);
  }

  PostRol(rol: Iroles)
  {
    return  this.httpClient.post(this.rolesUrlService, rol);
  }

  UpdateRoles(rol: Iroles) {
    return this.httpClient.put(this.rolesUrlService, rol);
  }
}
