import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieComponent } from './movie/movie.component';
import { GenreComponent } from './genre/genre.component';
import { theatreComponent } from './theatre/theatre.component';
import { CreateActorComponent } from './actors/create-actor/create-actor.component';
import { EditActorComponent } from './actors/edit-actor/edit-actor.component';
import { IndexActorsComponent } from './actors/index-actors/index-actors.component';
import { HomeComponent } from './home/home.component';




const routes: Routes = [
<<<<<<< HEAD
  {path: '', component: HomeComponent},
  {path:'movie', component: MovieComponent},
=======
  {path:'', component: MovieComponent},
>>>>>>> 2c42c9952f4510b830415f6d0b98ec62173d54d2
  {path:'genre', component: GenreComponent},
  {path:'theatre', component: theatreComponent},
  {path: 'actors', component: IndexActorsComponent},
  {path: 'actors/create', component: CreateActorComponent},
  {path: 'actors/edit/:id', component: EditActorComponent},
  {path: '**', redirectTo: ''}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
