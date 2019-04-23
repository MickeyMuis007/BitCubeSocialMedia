import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  isAuthorize = false;

  constructor(private authService: AuthService) { }

  ngOnInit() {
    this.authService.isAuthenticated().subscribe(
      res => {
        console.log('authorize');
        this.isAuthorize = true;
      },
      err => {
        console.clear();
        console.log('not authorize', err);
        this.isAuthorize = false;
      }
    );
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
