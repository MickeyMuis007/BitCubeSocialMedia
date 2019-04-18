import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  templateUrl: './sign-in.component.html'
})
export class SignInComponent implements OnInit {
  signInFormGroup: FormGroup;

  constructor(private formBuilder: FormBuilder) {

  }

  ngOnInit() { 

    this.buildFormGroup();
  }

  save() {
    if (this.signInFormGroup.valid) {
      console.log("Valid");
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
