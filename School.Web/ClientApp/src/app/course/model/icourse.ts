export interface Icourse {
  CourseId: string;
  SignaturesId: number;
  SchoolId: string;
  TeacherId: number;
  MinToPass: number;
  Year: number;
  Credits: number;
  StartDate: Date;
  EndDate: Date;
  IsActive: boolean;
  ScheduleId: number;
}
