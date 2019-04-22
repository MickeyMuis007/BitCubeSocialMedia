import { Component } from '@angular/core';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  templateUrl: './sign-out.component.html',
  styleUrls:  ['./sign-out.component.css']
})
export class SignOutComponent {
  constructor(private authService: AuthService) { }

  save() {
    this.authService.signOut().subscribe(
      res => console.log('Successfully signed out!'),
      err => console.error(err)
    )
  }
}
