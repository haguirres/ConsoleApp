import { Iperson } from "../../person/model/iperson";
import { IAddress } from "../../address/model";

export interface Istudent {
  PersonId: number;
  StudentId: number;
  Account: string;
  IsActive: boolean;
  student_person?: Iperson;
  student_address?: IAddress;
}
