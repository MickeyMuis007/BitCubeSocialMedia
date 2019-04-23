import { Friend } from "./friend.model";

export class User {
  id: string;
  email: string;
  firstName: string;
  lastName: string;
  friend1s: Friend[];
  friend2s: Friend[];
}
