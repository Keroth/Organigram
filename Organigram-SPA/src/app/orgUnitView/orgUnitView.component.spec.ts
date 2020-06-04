/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { orgUnitViewComponent } from './orgUnitView.component';

describe('orgUnitViewComponent', () => {
  let component: orgUnitViewComponent;
  let fixture: ComponentFixture<orgUnitViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ orgUnitViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(orgUnitViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
