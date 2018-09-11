import { Component, OnInit } from '@angular/core';
import { IschoolUser } from './model/ischool-user'
import { ApplicationDataServiceService, InscriptionHttpServiceService } from '../services/index';
import { SchooluserHttpService } from '../services/schooluser-http.service';

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

  GetInscriptios() {
    this.schoolUserHttpService.GetSchoolUser().subscribe(data => {
      this.schoolUserArray = data;
      console.log(data);
    });
  }


}
