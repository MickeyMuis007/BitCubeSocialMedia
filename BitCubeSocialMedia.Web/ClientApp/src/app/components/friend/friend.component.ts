import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/services/user.service';

@Component({
  templateUrl: './friend.component.html',
  styleUrls: ['./friend.component.css']
})
export class FriendComponent implements OnInit {
  isLoading: boolean;
  private email: string;

  constructor(private userService: UserService, private activatedRoute: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.isLoading = true;
    this.email = this.activatedRoute.snapshot.params['email'];
    this.userService.getUserByEmail(this.email).subscribe(
      (res) => {
        console.log('Successfully loaded users');
        this.router.navigate(['/']);
      },
      err => {
        console.error(err);
      }
    ).add(() => this.isLoading = false);
  }
}
