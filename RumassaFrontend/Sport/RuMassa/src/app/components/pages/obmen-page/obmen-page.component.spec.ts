import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObmenPageComponent } from './obmen-page.component';

describe('ObmenPageComponent', () => {
  let component: ObmenPageComponent;
  let fixture: ComponentFixture<ObmenPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ObmenPageComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ObmenPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
