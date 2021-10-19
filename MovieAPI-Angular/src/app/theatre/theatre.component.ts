import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-theatre',
  templateUrl: './theatre.component.html',
  styleUrls: ['./theatre.component.scss']
})
export class theatreComponent implements OnInit {
    theatreList: any;
    theatreid: any;
    name: any;
    constructor(private apiService: ApiService, private router: Router) { }
  
    ngOnInit(): void {
      this.apiService.getAllTheatres().subscribe((response: any)=>
      {
        this.theatreList = response.result_set;
        console.log(this.theatreList);
      }
      );
    }
  
    deletetheatre(id: any): void {
      this.apiService.deleteTheatre(id)
        .subscribe(
          response => {
            console.log(response);
          }
          
          );
          window.location.reload();
    }
  
    createtheatre(data:any): void {
      this.name = data.name;
      console.log(data);
      this.apiService.createTheatre(this.name)
        .subscribe(
          response => {
            console.log(response);
          }
          
          );
          window.location.reload();
         
    }
  
    updatetheatre(data:any): void {
      this.theatreid = data.theatre_id;
      this.name = data.name;
      this.apiService.updateTheatre(this.theatreid,this.name)
        .subscribe(
          response => {
            console.log(response);
          }
          );
          window.location.reload();
    }
  }
