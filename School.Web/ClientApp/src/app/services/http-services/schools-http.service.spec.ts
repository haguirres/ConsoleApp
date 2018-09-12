import { TestBed, inject } from '@angular/core/testing';

import { SchoolsHttpService } from './schools-http.service';

describe('SchoolsHttpService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SchoolsHttpService]
    });
  });

  it('should be created', inject([SchoolsHttpService], (service: SchoolsHttpService) => {
    expect(service).toBeTruthy();
  }));
});
