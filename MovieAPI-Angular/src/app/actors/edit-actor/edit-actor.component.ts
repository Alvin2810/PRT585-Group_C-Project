import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { actorCreationDTO, actorDTO } from '../actors.model';

@Component({
  selector: 'app-edit-actor',
  templateUrl: './edit-actor.component.html',
  styleUrls: ['./edit-actor.component.scss']
})
export class EditActorComponent implements OnInit {

  constructor(private activatedRoute:ActivatedRoute) {}
  model: actorDTO = {
    name:'Elijah Wood', 
    dateOfBirth: new Date(), 
    biography:'',
    picture: 'https://m.media-amazon.com/images/M/MV5BMTM0NDIxMzQ5OF5BMl5BanBnXkFtZTcwNzAyNTA4Nw@@._V1_UX214_CR0,0,214,317_AL_.jpg'
  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      ///alert(params.id)
    })
  }

  saveChanges(actorCreationDTO: actorCreationDTO){
    console.log(actorCreationDTO);

  }
}
