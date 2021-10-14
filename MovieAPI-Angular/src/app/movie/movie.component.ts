import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.scss']
})
export class MovieComponent implements OnInit {
    movieList: any;
    movieid: any;
    name: any;
    language: any;
   releaseDate: any;
    constructor(private apiService: ApiService, private router: Router) { }
  
    ngOnInit(): void {
      this.apiService.getAllMovies().subscribe((response: any)=>
      {
        this.movieList = response.result_set;
        console.log(this.movieList);
      }
      );
    }
  
    deleteMovie(id: any): void {
      this.apiService.deleteMovie(id)
        .subscribe(
          response => {
            console.log(response);
          }
          
          );
          window.location.reload();
    }
  
    createMovie(data:any): void {
      this.name = data.name;
      this.releaseDate = data.releaseDate;
      this.language = data.language;
      console.log(data);
      this.apiService.createMovie(this.name, this.releaseDate, this.language)
        .subscribe(
          response => {
            console.log(response);
          }
          
          );
          window.location.reload();
         
    }
  
    updateMovie(data:any): void {
      this.movieid = data.movie_id;
      this.name = data.name;
      this.releaseDate = data.releaseDate;
      this.language = data.language;
      this.apiService.updateMovie(this.movieid,this.name, this.releaseDate, this.language)
        .subscribe(
          response => {
            console.log(response);
          }
          );
          window.location.reload();
    }
  }
