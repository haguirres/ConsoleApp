import { Component, OnInit } from '@angular/core';
import { IweekDay } from './model/iweek-day'

@Component({
  selector: 'app-week-day',
  templateUrl: './week-day.component.html',
  styleUrls: ['./week-day.component.css']
})
export class WeekDayComponent implements OnInit {

  WeekDay = <IweekDay>{};
  constructor() { }

  ngOnInit() {
  }

  SaveWeekDay() {
    alert("El día es: " + this.WeekDay.Day);
  }
}
