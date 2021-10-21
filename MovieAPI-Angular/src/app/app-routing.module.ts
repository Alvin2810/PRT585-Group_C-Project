import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieComponent } from './movie/movie.component';
import { GenreComponent } from './genre/genre.component';
import { theatreComponent } from './theatre/theatre.component';

import { IndexActorsComponent } from './actors/index-actors/index-actors.component';
import { EditActorComponent } from './actors/edit-actor/edit-actor.component';
import { CreateActorComponent } from './actors/create-actor/create-actor.component';
import { FormActorComponent } from './actors/form-actor/form-actor.component';


import { HomeComponent } from './home/home.component';










const routes: Routes = [
  {path: '', component: HomeComponent},
  {path:'movie', component: MovieComponent},
  {path:'genre', component: GenreComponent},
  {path:'theatre', component: theatreComponent},
  
  {path: 'actors', component: IndexActorsComponent},
  {path:'actors/edit/:id', component: EditActorComponent},
  {path:'actors/create', component:CreateActorComponent},
  {path:'actors/form', component: FormActorComponent},

  

  {path: '**', redirectTo: ''}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
