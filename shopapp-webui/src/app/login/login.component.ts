import { LoginService } from './login.service';
import { Component, OnInit } from '@angular/core';
import { User } from '../models/Concrete/User';
import 'rxjs/add/operator/map';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  public user:User;

  constructor(private loginService: LoginService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.user.Password="x15471547x";
    this.user.UserName="1huseyinyildiz";


    // this.loginService.login(this.user)
    //   .then(response=>{

    //   });

    }
  }

