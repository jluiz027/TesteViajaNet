import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TesteviajanetComponent } from './testeviajanet.component';

describe('TesteviajanetComponent', () => {
  let component: TesteviajanetComponent;
  let fixture: ComponentFixture<TesteviajanetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TesteviajanetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TesteviajanetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
