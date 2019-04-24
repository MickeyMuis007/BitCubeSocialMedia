import { User } from "./user.model";
import { Guid } from "guid-typescript";

export class Friend {
  id: Guid;
  friend1Id: Guid;
  friend2Id: Guid;
}
