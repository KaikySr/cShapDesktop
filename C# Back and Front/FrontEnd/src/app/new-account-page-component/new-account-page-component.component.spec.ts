import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewAccountPageComponentComponent } from './new-account-page-component.component';

describe('NewAccountPageComponentComponent', () => {
  let component: NewAccountPageComponentComponent;
  let fixture: ComponentFixture<NewAccountPageComponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NewAccountPageComponentComponent]
    });
    fixture = TestBed.createComponent(NewAccountPageComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
