import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private http:HttpClient) { }

  ngOnInit() {
    // this.http.get<any>("https://localhost:44338/Product").subscribe(response=>{
    //   if(response){

    //   }
    //});
  }
  onClick(){
    this.http.get<any>("https://localhost:5001/Product").subscribe((response)=>{
      if(response){
        console.log("5001",response);
      }
    });

    this.http.get('https://localhost:5001/Product').subscribe((res)=>{
      console.log(res);
  });
  }

}
