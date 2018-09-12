import { Component, OnInit } from '@angular/core';
import { IschoolUser } from './model/ischool-user'
import { ApplicationDataServiceService, InscriptionHttpServiceService } from '../services/index';
import { SchooluserHttpService } from '../services/schooluser-http.service';
import { Data } from '@angular/router';

@Component({
  selector: 'app-school-user',
  templateUrl: './school-user.component.html',
  styleUrls: ['./school-user.component.css']
})
export class SchoolUserComponent implements OnInit {

  schoolUser = <IschoolUser>{};
  schoolUserArray: IschoolUser[] = [];

  constructor(private applicationDataService: ApplicationDataServiceService,
    private schoolUserHttpService: SchooluserHttpService) {
    console.log(applicationDataService);
  }

  ngOnInit() {
  }

  GetSchoolUsers() {
    this.schoolUserHttpService.GetSchoolUsers().subscribe(data => {
      this.schoolUserArray = data;
      console.log(data);
    });
  }

  DeleteSchoolUser() {

    this.schoolUserHttpService.DeleteSchoolUser(this.Id).subscribe(data => {
      alert('school user eliminado');
    });
  }

  Id: number;

  PostSchoolUser() {

    

    this.schoolUserHttpService.PostSchoolUser(this.schoolUser).subscribe(data => {
      console.log(data);
      alert('school user creado');

    });

  }

  

  
  

  //add(name: string): void {
  //  name = name.trim();
  //  if (!name) { return; }
  //  this.schoolUserHttpService.addschoolUser({ name } as IschoolUser)
  //    .subscribe(data => {
  //      this.schoolUserArray.push(data);
  //    });
  //}



}
