import { ComponentFixture, TestBed } from '@angular/core/testing';

import { theatreComponent } from './theatre.component';

describe('TheatreComponent', () => {
  let component: theatreComponent;
  let fixture: ComponentFixture<theatreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ theatreComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(theatreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
