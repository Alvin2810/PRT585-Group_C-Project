import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  ngOnInit(): void {
    this.actorsInHome = [
      {
        name: 'Tome Cruise',
        dOB: new Date('1962-07-03'),
        poster: 'https://www.biography.com/.image/t_share/MTc5ODc1NTM4NjMyOTc2Mzcz/gettyimages-693134468.jpg'
      },
      {
        name: 'Leonardo Dicaprio',
        dOB: new Date('1974-11-11'),
        poster: 'https://images.saymedia-content.com/.image/ar_1:1%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:eco%2Cw_1200/MTc0NDI5MTc5NzI1NDg5Nzk4/top-10-greatest-leonardo-dicaprio-movies.jpg'
      },
    
   ];
  }

  actorsInHome: any;
}