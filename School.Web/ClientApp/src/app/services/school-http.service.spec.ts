import { TestBed, inject } from '@angular/core/testing';

import { SchoolHttpService } from './school-http.service';

describe('SchoolHttpService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SchoolHttpService]
    });
  });

  it('should be created', inject([SchoolHttpService], (service: SchoolHttpService) => {
    expect(service).toBeTruthy();
  }));
});
