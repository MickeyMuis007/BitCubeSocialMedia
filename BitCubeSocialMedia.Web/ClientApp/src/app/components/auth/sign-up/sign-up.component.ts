import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ConfirmPasswordValidator } from 'src/app/shared/validators/confirm-password.validator';

@Component({
  templateUrl: './sign-up.component.html'
})
export class SignUpComponent implements OnInit {
  signUpForm: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.buildFormGroup();
  }

  save() {

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
