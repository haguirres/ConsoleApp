import { IAddress } from '../../address/model/index';

export interface ISchool
{
  SchoolId: string;
  AddressId?: number;
  SchoolName: string;
  SchoolType: number;
  MinToPass: number;
  IsActive: boolean;
  SchoolAddress?: IAddress;
}
