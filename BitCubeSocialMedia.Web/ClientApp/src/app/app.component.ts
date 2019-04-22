import { Component, OnInit } from '@angular/core';
import { AuthService } from './services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private authService: AuthService) { }

  isAuthorize = false;

  ngOnInit() {
    this.authService.isAuthenticated().subscribe(
      res => {
        console.log('authorize');
        this.isAuthorize = true;
      },
      err => {
        console.log('not authorize');
        this.isAuthorize = false;
      }
    );
  }
}
