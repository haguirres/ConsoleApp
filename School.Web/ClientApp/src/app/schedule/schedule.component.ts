import { Component, OnInit } from '@angular/core';
import { Ischedule } from './model/ischedule';
@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  styleUrls: ['./schedule.component.css']
})
export class ScheduleComponent implements OnInit {

  schedule = <Ischedule>{};
  constructor() { }
  
  ngOnInit() {
    
  }

}
