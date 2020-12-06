import { Constants } from './../models/constants';
import { User } from './../models/Concrete/User';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class LoginService {

  constructor(private http: HttpClient) { }

   login(user:User){
       // tslint:disable-next-line: no-unused-expression
       this.http.get<User>(
      Constants.APIBaseAddress+
      Constants.User + "/" +
      Constants.Login+ '/' + user).toPromise();
  }
   forgetPassword(){

  }

}


