import { IAddress } from '../../address/model/index';

export interface ISchool
{
  SchoolId: number;
  SchoolAddressId?: number;
  SchoolName: string;
  SchoolTypeName: string;
  SchoolTypeId?: number;
  MinToPass: number;
  SchoolIsActive: boolean;
  SchoolAddress?: IAddress;
}
