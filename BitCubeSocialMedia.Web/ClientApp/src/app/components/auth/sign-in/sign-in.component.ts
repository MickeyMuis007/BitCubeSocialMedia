import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { SignIn } from 'src/app/shared/models/sign-in.model';

@Component({
  templateUrl: './sign-in.component.html'
})
export class SignInComponent implements OnInit {
  signInFormGroup: FormGroup;
  isLoading = false;

  constructor(private formBuilder: FormBuilder, private authService: AuthService, private router: Router) {

  }

  ngOnInit() { 

    this.buildFormGroup();
  }

  save() {
    if (this.signInFormGroup.valid) {
      console.log("Valid");
      let signInModel: SignIn = new SignIn();
      signInModel.email = this.signInFormGroup.controls.email.value;
      signInModel.password = this.signInFormGroup.controls.password.value;

      this.isLoading = true;
      this.authService.signIn(signInModel).subscribe(
        res => {
          console.log('Successfully signed in!');
          this.router.navigate(['/']);
        },
        err => console.error(err)
      ).add(() => this.isLoading = false );
    }
    else {
      console.log("Invalid")
    }
  }

  private buildFormGroup() {
    this.signInFormGroup = this.formBuilder.group({
      email: ['', Validators.compose([Validators.required, Validators.email])],
      password: ['', Validators.required ]
    });

  }
}
