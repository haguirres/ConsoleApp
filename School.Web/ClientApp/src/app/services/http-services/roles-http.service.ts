import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Iroles } from '../../roles/Models/Iroles';
import { environment } from '../../../environments/environment';

@Injectable()
export class RolesHttpService {
  constructor(private httpClient: HttpClient) { }
  private rolApiUrl = environment.apiUrl + environment.catalogsPath + environment.apiCatalogsUrl.rol;
  private rolesApiUrl = environment.apiUrl + environment.catalogsPath + environment.apiCatalogsUrl.roles;

  GetRol(rolId: number) {
    //let params = new HttpParams().set('rolId', rolId.toString());
    //return this.httpClient.get<Iroles>(this.rolesApiUrl, { params });

    return this.httpClient.get<Iroles>(this.rolApiUrl + '/' + rolId);
  }

  GetRoles() {
    return this.httpClient.get<Iroles[]>(this.rolesApiUrl);
  }

  PostRol(rol: Iroles) {
    return this.httpClient.post(this.rolApiUrl, rol);
  }

  UpdateRoles(rolId: number, rol: Iroles) {
    return this.httpClient.put(this.rolApiUrl + "/" + rolId, rol);
  }

  DeleteRol(rolId: number)
  {
    return this.httpClient.delete(this.rolApiUrl + '/' + rolId);
  }
}
