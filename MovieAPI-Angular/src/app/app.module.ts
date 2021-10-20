import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule, HttpClientJsonpModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import { MatTabsModule } from '@angular/material/tabs';
import {MatDividerModule} from '@angular/material/divider';
import { MatSliderModule } from '@angular/material/slider';
import { InputsModule } from '@progress/kendo-angular-inputs';
import {TextFieldModule} from '@angular/cdk/text-field';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MovieComponent } from './movie/movie.component';
import { GenreComponent } from './genre/genre.component';
import { theatreComponent } from './theatre/theatre.component';
import  {MarkdownModule} from 'ngx-markdown';
import { MatDatepickerModule } from "@angular/material/datepicker";

import { MaterialModule } from './material/material.module';

import { MenuComponent } from './menu/menu.component';
import { IndexActorsComponent } from './actors/index-actors/index-actors.component';
import { CreateActorComponent } from './actors/create-actor/create-actor.component';
import { EditActorComponent } from './actors/edit-actor/edit-actor.component';
import { HomeComponent } from './home/home.component';
import { FormActorComponent } from './actors/form-actor/form-actor.component';
import { InputImgComponent } from './utilities/input-img/input-img.component';
import { InputMarkdownComponent } from './utilities/input-markdown/input-markdown.component';






@NgModule({
  declarations: [
    AppComponent,
    MovieComponent,
    GenreComponent,
    theatreComponent,
    MenuComponent,
    IndexActorsComponent,
    CreateActorComponent,
    EditActorComponent,
    HomeComponent,
    FormActorComponent,
    InputImgComponent,
    InputMarkdownComponent
  ],
  entryComponents: [],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    DropDownsModule,
    MatIconModule,
    InputsModule,
    MatDividerModule,
    MatButtonModule,
    BrowserAnimationsModule,
    MatSliderModule,
    TextFieldModule,
    HttpClientJsonpModule,
    MatFormFieldModule,
    MaterialModule,
    MarkdownModule.forRoot(),
    MatTabsModule,
    MatDatepickerModule


],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
