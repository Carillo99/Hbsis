import { TestBed } from '@angular/core/testing';

import { MinimumWageService } from './minimum-wage.service';

describe('MinimumWageService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MinimumWageService = TestBed.get(MinimumWageService);
    expect(service).toBeTruthy();
  });
});
