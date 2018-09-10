import { TestBed, inject } from '@angular/core/testing';

import { ApplicationDataServiceService } from './application-data-service.service';

describe('ApplicationDataServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ApplicationDataServiceService]
    });
  });

  it('should be created', inject([ApplicationDataServiceService], (service: ApplicationDataServiceService) => {
    expect(service).toBeTruthy();
  }));
});
