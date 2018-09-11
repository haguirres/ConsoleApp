import { TestBed, inject } from '@angular/core/testing';

import { InscriptionHttpServiceService } from './inscription-http-service.service';

describe('InscriptionHttpServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [InscriptionHttpServiceService]
    });
  });

  it('should be created', inject([InscriptionHttpServiceService], (service: InscriptionHttpServiceService) => {
    expect(service).toBeTruthy();
  }));
});
