import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { User } from "../shared/models/user.model";


@Injectable({
  providedIn: 'root'
})
export class UserService {
  private baseUrl = `${location.origin}/api/user`;

  constructor(private httpClient: HttpClient) { }

  getUserByEmail(email: string): Observable<User> {
    return this.httpClient.get<User>(`${this.baseUrl}/${email}`);
  }
}
