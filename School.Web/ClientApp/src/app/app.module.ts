import { BrowserModule } from '@angular/platform-browser';
import { NgModule, LOCALE_ID } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { SchoolComponent } from './school/school.component';
import { TeacherComponent } from './teacher/teacher.component';
import { SchoolTypeComponent } from './school-type/school-type.component';
import { AddressComponent } from './address/address.component';
import { StudentComponent } from './student/student.component';
import { PersonComponent } from './person/person.component';
import { GradeComponent } from './grade/grade.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    SchoolComponent,
    TeacherComponent,
    SchoolTypeComponent,
    StudentComponent,
    PersonComponent,
    GradeComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'school', component: SchoolComponent }

    ])
  ],
  //providers: [{ provide: LOCALE_ID, useValue: 'es-419' }],

  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
