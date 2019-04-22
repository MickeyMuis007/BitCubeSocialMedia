import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ConfirmPasswordValidator } from 'src/app/shared/validators/confirm-password.validator';
import { AuthService } from 'src/app/services/auth.service';
import { SignUp } from 'src/app/shared/models/sign-up.model';

@Component({
  templateUrl: './sign-up.component.html'
})
export class SignUpComponent implements OnInit {
  signUpForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private authService: AuthService, private router: Router) { }

  ngOnInit() {
    this.buildFormGroup();
  }

  save() {
    if (this.signUpForm.valid) {
      console.log('SignUp: Valid');
      let signUpModel: SignUp = new SignUp();
      signUpModel.email = this.signUpForm.controls.email.value;
      signUpModel.firstName = this.signUpForm.controls.firstName.value;
      signUpModel.lastName = this.signUpForm.controls.lastName.value;
      signUpModel.password = this.signUpForm.controls.password.value;
      signUpModel.confirmPassword = this.signUpForm.controls.confirmPassword.value;

      this.authService.signUp(signUpModel).subscribe(
        res => {
          console.log('Successfully signed up!');
          this.router.navigate(['/'])
          window.location.reload();
        },
        err => console.error(err)
      );
    }
  }

  private buildFormGroup() {
    this.signUpForm = this.formBuilder.group({
      email: ['', Validators.compose([Validators.required, Validators.email])],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      password: ['', Validators.compose([Validators.required, Validators.minLength(8)])],
      confirmPassword: ['']
    }, {
        validator: ConfirmPasswordValidator.MatchPassword
    });
  }
}
