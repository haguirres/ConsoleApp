import { Component, OnInit } from '@angular/core';
import { Isignature } from './model/isignature'

@Component({
  selector: 'app-signature',
  templateUrl: './signature.component.html',
  styleUrls: ['./signature.component.css']
})
export class SignatureComponent implements OnInit {

  Signature = <Isignature>{};

  constructor() { }

  ngOnInit() {
  }

  SaveSignature() {
    alert("El nombre de la asignatura es: " + this.Signature.SignaturesName);
  }

}
