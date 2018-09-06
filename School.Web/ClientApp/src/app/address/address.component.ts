import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { IAddress } from './model/index';
import { ISchool } from '../school/model/ISchool';
import { IschoolType } from '../school-type/model/ischool-type';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {
  //address = <IAddress>{};
  @Input() address: IAddress;
  @Output() ShowAlert = new EventEmitter<boolean>();
  



  schoolTypes: IschoolType[] = [
    { SchoolTypeId: 1, Type: '14000' },
    { SchoolTypeId: 2, Type: '15000' },
    { SchoolTypeId: 3, Type: '16000' }];
  schoolTypeSelected = <IschoolType>{};


  constructor() { }

  ngOnInit() {
  }

  MostrarAlerta()
  {
    
    //alert('Alerta del componente hijo');
    
    
   //this.ShowAlert.emit(true);
    this.ShowAlert.emit(true);
  }

}
