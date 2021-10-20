import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-index-actors',
  templateUrl: './index-actors.component.html',
  styleUrls: ['./index-actors.component.scss']
})
export class IndexActorsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input()
  actors: any

  remove(index: number){
    this.actors.splice(index, 1);
  }

}
