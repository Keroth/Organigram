/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { OrgUnitService } from './OrgUnit.service';

describe('Service: OrgUnit', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [OrgUnitService]
    });
  });

  it('should ...', inject([OrgUnitService], (service: OrgUnitService) => {
    expect(service).toBeTruthy();
  }));
});
