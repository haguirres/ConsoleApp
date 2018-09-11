import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Iroles } from '../roles/Models/Iroles';
import { environment } from '../../environments/environment';

@Injectable()
export class SchoolHttpService {
  constructor(private httpClient: HttpClient) { }

  private catalogsBaseUrl = environment.apiUrl + environment.catalogsPath;


  GetRoles()
  {
    return this.httpClient.get<Iroles[]>(this.catalogsBaseUrl + environment.apiCatalogsUrl.rol);
  }

  PostRol(rol: Iroles)
  {
    return this.httpClient.post(this.catalogsBaseUrl + environment.apiCatalogsUrl.rol, rol);
  }

  UpdateRoles(rol: Iroles) {
    return this.httpClient.put(this.catalogsBaseUrl + environment.apiCatalogsUrl.rol, rol);
  }
}
