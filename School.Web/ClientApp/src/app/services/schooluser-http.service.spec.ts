import { TestBed, inject } from '@angular/core/testing';

import { SchooluserHttpService } from './schooluser-http.service';

describe('SchooluserHttpService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SchooluserHttpService]
    });
  });

  it('should be created', inject([SchooluserHttpService], (service: SchooluserHttpService) => {
    expect(service).toBeTruthy();
  }));
});
