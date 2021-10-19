import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieComponent } from './movie/movie.component';
import { GenreComponent } from './genre/genre.component';



const routes: Routes = [
  {path:'movie', component: MovieComponent},
  {path:'genre', component: GenreComponent}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
