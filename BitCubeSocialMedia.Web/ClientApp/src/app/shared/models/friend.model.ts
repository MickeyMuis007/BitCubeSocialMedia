import { User } from "./user.model";

export class Friend {
  id: string;
  friend1Id: string;
  friend2Id: string;
  friend1: User;
  friend2: User;
}
