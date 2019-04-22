import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  templateUrl: './sign-out.component.html',
  styleUrls:  ['./sign-out.component.css']
})
export class SignOutComponent {
  constructor(private authService: AuthService, private router: Router) { }

  save() {
    this.authService.signOut().subscribe(
      res => {
        console.log('Successfully signed out!');
        this.router.navigate(['/']);
      },
      err => console.error(err)
    )
  }
}
