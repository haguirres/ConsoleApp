import { Component, OnInit } from '@angular/core';
import {Iinscription } from './Models/Iinscription'

@Component({
  selector: 'app-inscription',
  templateUrl: './inscription.component.html',
  styleUrls: ['./inscription.component.css']
})
export class InscriptionComponent implements OnInit {
  inscription = <Iinscription>{};

  constructor() { }

  ngOnInit() {
  }

}
