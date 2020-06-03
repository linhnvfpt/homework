import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChoosenComponentComponent } from './choosen-component.component';

describe('ChoosenComponentComponent', () => {
  let component: ChoosenComponentComponent;
  let fixture: ComponentFixture<ChoosenComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChoosenComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChoosenComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
