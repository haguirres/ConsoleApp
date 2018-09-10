import { IAddress } from "../../address/model";

export interface Iperson {
  PersonId: number;
  PersonFirstName: string;
  PersonLastName: string;
  PersonAge: number;
  AddressId: number;
  CURP: string;
  Phone: number;
  Email: string;
  address?: IAddress;
}
