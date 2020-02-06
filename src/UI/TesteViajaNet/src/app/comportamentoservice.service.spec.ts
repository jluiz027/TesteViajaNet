import { TestBed } from '@angular/core/testing';

import { ComportamentoserviceService } from './comportamentoservice.service';

describe('ComportamentoserviceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ComportamentoserviceService = TestBed.get(ComportamentoserviceService);
    expect(service).toBeTruthy();
  });
});
