
import { Iperson } from "../../person/model/iperson";

export interface ITeacher {
  PersonId: number;
  TeacherId: number;
  RFC: string;
  IsActive: boolean;
  
  Person?: Iperson;
}
