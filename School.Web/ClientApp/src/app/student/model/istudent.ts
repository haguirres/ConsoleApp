import { Iperson } from '../../person/model/iperson';
import { IAddress } from '../../address/model/IAddress';

export interface Istudent {
  PersonId: number;
  StudentId: number;
  Account: string;
  IsActive: boolean;
  StudentPerson?: Iperson;
  StudentAddress?: IAddress; 
}
