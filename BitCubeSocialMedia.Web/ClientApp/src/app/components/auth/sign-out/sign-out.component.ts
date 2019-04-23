import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  templateUrl: './sign-out.component.html',
  styleUrls:  ['./sign-out.component.css']
})
export class SignOutComponent {
  isLoading = false;

  constructor(private authService: AuthService, private router: Router) { }

  save() {
    this.isLoading = true;
    this.authService.signOut().subscribe(
      res => {
        console.log('Successfully signed out!');
        this.router.navigate(['/']);
        localStorage.setItem('user', null);
      },
      err => console.error(err)
    ).add(() => this.isLoading = false);
  }
}
