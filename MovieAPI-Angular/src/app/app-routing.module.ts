import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieComponent } from './movie/movie.component';
import { GenreComponent } from './genre/genre.component';
import { theatreComponent } from './theatre/theatre.component';



const routes: Routes = [
  {path:'', component: MovieComponent},
  {path:'genre', component: GenreComponent},
  {path:'theatre', component: theatreComponent}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
