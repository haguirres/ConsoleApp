import { Iperson } from "../../person/model/iperson";

export interface Istudent {
  PersonId: number;
  StudentId: number;
  Account: string;
  IsActive: boolean;
  student_person?: Iperson;
}
