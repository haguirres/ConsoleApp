import { IAddress } from "../../address/model";

export interface Iperson {
  PersonId: number;
  PersonName: string;
  PersonAge: number;
  AddressId: number;
  CURP: string;
  Phone: number;
  Email: string;
  address?: IAddress;
  //PersonAddress?: IAddress;
}
