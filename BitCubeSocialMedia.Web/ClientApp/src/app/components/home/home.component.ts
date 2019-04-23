import { Component, OnInit, Input } from '@angular/core';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  @Input() isAuthorize;

  ngOnInit() {
    console.log(this.isAuthorize)
  }
}
