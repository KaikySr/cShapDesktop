import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComunityPageComponentComponent } from './comunity-page-component.component';

describe('ComunityPageComponentComponent', () => {
  let component: ComunityPageComponentComponent;
  let fixture: ComponentFixture<ComunityPageComponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ComunityPageComponentComponent]
    });
    fixture = TestBed.createComponent(ComunityPageComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
