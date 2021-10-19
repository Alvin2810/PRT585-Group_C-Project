import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-genre',
  templateUrl: './genre.component.html',
  styleUrls: ['./genre.component.scss']
})
export class GenreComponent implements OnInit {
    genreList: any;
    genreid: any;
    name: any;
    constructor(private apiService: ApiService, private router: Router) { }
  
    ngOnInit(): void {
      this.apiService.getAllGenres().subscribe((response: any)=>
      {
        this.genreList = response.result_set;
        console.log(this.genreList);
      }
      );
    }
  
    deleteGenre(id: any): void {
      this.apiService.deleteGenre(id)
        .subscribe(
          response => {
            console.log(response);
          }
          
          );
          window.location.reload();
    }
  
    createGenre(data:any): void {
      this.name = data.name;
      console.log(data);
      this.apiService.createGenre(this.name)
        .subscribe(
          response => {
            console.log(response);
          }
          
          );
          window.location.reload();
         
    }
  
    updateGenre(data:any): void {
      this.genreid = data.genre_id;
      this.name = data.name;
      this.apiService.updateGenre(this.genreid,this.name)
        .subscribe(
          response => {
            console.log(response);
          }
          );
          window.location.reload();
    }
  }
