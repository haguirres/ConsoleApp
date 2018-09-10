import { Component, OnInit } from '@angular/core';
import {Iinscription } from './Models/Iinscription'
//import { ApplicationDataServiceService } from '../services/application-data-service.service';
import {ApplicationDataServiceService,InscriptionHttpServiceService } from '../services/index';

@Component({
  selector: 'app-inscription',
  templateUrl: './inscription.component.html',
  styleUrls: ['./inscription.component.css']
})
export class InscriptionComponent implements OnInit {
  inscription = <Iinscription>{};
  inscriptionArray: Iinscription[]=[];

  constructor(private applicationDataService: ApplicationDataServiceService,
    private inscriptionHttpService: InscriptionHttpServiceService) {
    console.log(applicationDataService);
  }

  ngOnInit() {
  }

  GetInscriptios() {
    this.inscriptionHttpService.GetInscriptions().subscribe(data => {
      this.inscriptionArray = data;
      console.log(data);
    });
  }

}
