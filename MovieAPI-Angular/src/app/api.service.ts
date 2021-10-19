import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private httpClient: HttpClient) { }

  public getAllMovies(){
    return this.httpClient.get('https://localhost:44341/api/Movie/GetAllMovies');
  }
  public deleteMovie(Id: any){
    return this.httpClient.get('https://localhost:44341/api/Movie/DeleteMovie?movie_id='+Id);
  }
  public createMovie(name: string, releaseDate : string, language: string){
    return this.httpClient.get('https://localhost:44341/api/Movie/AddMovie?name='+name+'&releaseDate='+releaseDate+'&language='+language);
  }
  public updateMovie(Id: any, name:string,releaseDate : string, language: string){
      return this.httpClient.get('https://localhost:44341/api/Movie/UpdateMovie?movie_id='+Id+'&name='+name+'&releaseDate='+releaseDate+'&language='+language);
  
  }

  public getAllGenres(){
    return this.httpClient.get('https://localhost:44341/api/Genre/GetAllGenres');
  }
  public deleteGenre(Id: any){
    return this.httpClient.get('https://localhost:44341/api/Genre/DeleteGenre?genre_id='+Id);
  }
  public createGenre(name: string){
    return this.httpClient.get('https://localhost:44341/api/Genre/AddGenre?name='+name);
  }
  public updateGenre(Id: any, name:string){
      return this.httpClient.get('https://localhost:44341/api/Genre/UpdateGenre?genre_id='+Id+'&name='+name);
  
  }
  public getAllTheatres(){
    return this.httpClient.get('https://localhost:44341/api/Theatre/GetAllTheatres');
  }
  public deleteTheatre(Id: any){
    return this.httpClient.get('https://localhost:44341/api/Theatre/DeleteTheatre?theatre_id='+Id);
  }
  public createTheatre(name: string){
    return this.httpClient.get('https://localhost:44341/api/Theatre/AddTheatre?name='+name);
  }
  public updateTheatre(Id: any, name:string){
      return this.httpClient.get('https://localhost:44341/api/Theatre/UpdateTheatre?theatre_id='+Id+'&name='+name);
  
  }
}
