import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  values: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
    console.log(this.values);
  }
  getValues() {
    this.http.get('https://localhost:44321/api/values').subscribe(
      response => {
        this.values = response;
      }, error => {
        console.log(error);
      }
    );

  }

}
