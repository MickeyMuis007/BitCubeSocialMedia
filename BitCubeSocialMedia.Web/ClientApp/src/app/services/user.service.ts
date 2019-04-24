import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders, HttpErrorResponse } from "@angular/common/http";
import { Observable, throwError } from 'rxjs';
import { Response } from '@angular/http';
import { User } from "../shared/models/user.model";
import { catchError, map } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private baseUrl = `${location.origin}/api/user`;

  constructor(private httpClient: HttpClient) { }

  getUserByEmail(email: string): Observable<User> {
    return this.httpClient.get<User>(`${this.baseUrl}/${email}`).pipe(
      map(this.extractData),
      catchError(this.handleError)
    );
  }

  private extractData(res: Response) {
    let body = res;
    return body || {};
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error("An error occurred:", error.error.message);
    } else {
      // The backend returned an unsuccessful response code. The response body may contain clues as to what went wrong,
      console.error(
        `Backend returned code ${error.status}, ` + `body was: ${error.error}`
      );
    }
    // return an observable with a user-facing error message
    return throwError(error);
  }
}
