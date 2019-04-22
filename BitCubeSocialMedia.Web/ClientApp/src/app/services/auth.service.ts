import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { SignUp } from 'src/app/shared/models/sign-up.model';
import { SignIn } from '../shared/models/sign-in.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private httpClient: HttpClient) { }

  private baseUrl = location.origin + '/api/auth';

  signUp(signUpModel: SignUp) {
    return this.httpClient.post(`${this.baseUrl}/signup`, signUpModel);
  }

  signIn(signInModel: SignIn) {
    return this.httpClient.post(`${this.baseUrl}/signin`, signInModel);
  }

  signOut() {
    return this.httpClient.get(`${this.baseUrl}/signout`);
  }

  isAuthenticated() {
    return this.httpClient.get(`${this.baseUrl}/isauthorize`);
  }
}

