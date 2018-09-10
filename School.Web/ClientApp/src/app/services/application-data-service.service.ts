import { Injectable } from '@angular/core';

@Injectable()
export class ApplicationDataServiceService {

  userName = 'usuario@mobiik.com';
  private userPassword: string;

  constructor() {}

  getUserPassword(): string
  {
    return 'paswword del usuario';
  }

  ObtenerPassword() {
    console.log(this.userName);
    
    console.log(this.getUserPassword());
  }

}
