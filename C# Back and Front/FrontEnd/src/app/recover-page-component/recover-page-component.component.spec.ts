import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecoverPageComponentComponent } from './recover-page-component.component';

describe('RecoverPageComponentComponent', () => {
  let component: RecoverPageComponentComponent;
  let fixture: ComponentFixture<RecoverPageComponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RecoverPageComponentComponent]
    });
    fixture = TestBed.createComponent(RecoverPageComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
