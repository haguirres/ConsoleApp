import { Component, OnInit } from '@angular/core';
import { IweekDay } from './model/iweek-day'

@Component({
  selector: 'app-week-day',
  templateUrl: './week-day.component.html',
  styleUrls: ['./week-day.component.css']
})
export class WeekDayComponent implements OnInit {

  weekdays: IweekDay[] = [
    { WdId: 1, Day: 'All Week Days' }
  ];

  //WeekDay = <IweekDay>{ Day:'All week days' };
  constructor() { }

  ngOnInit() {
  }

}
