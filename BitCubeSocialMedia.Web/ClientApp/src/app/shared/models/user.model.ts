import { Friend } from "./friend.model";
import { Guid } from 'guid-typescript';

export class User {
  id: Guid;
  email: string;
  firstName: string;
  lastName: string;
  friends?: User[];
  notFriends?: User[];
}
