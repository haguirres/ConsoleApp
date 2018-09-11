import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Iinscription } from '../inscription/Models/Iinscription';

@Injectable()
export class InscriptionHttpServiceService {
  private inscriptionUrlService = 'http://localhost:38237/api/inscriptions';
  constructor(private httpCliente: HttpClient) { }


  GetInscriptions() {
    return this.httpCliente.get <Iinscription[]>(this.inscriptionUrlService);
  }

  PostInscriptions(inscription: Iinscription) {
    return this.httpCliente.post(this.inscriptionUrlService, inscription);
  }

  UpdateInscriptions(inscription: Iinscription) {
    return this.httpCliente.put(this.inscriptionUrlService, inscription);
  }

  DeleteInscrptions(inscription: Iinscription) {
    return this.httpCliente.delete(this.inscriptionUrlService);
  }
}
