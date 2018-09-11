import { TestBed, inject } from '@angular/core/testing';

import { RolesHttpService } from './roles-http.service';

describe('RolesHttpService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RolesHttpService]
    });
  });

  it('should be created', inject([RolesHttpService], (service: RolesHttpService) => {
    expect(service).toBeTruthy();
  }));
});
