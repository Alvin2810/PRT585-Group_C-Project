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
}
