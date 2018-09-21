import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { RequestOptions } from '@angular/http';
import { Observable } from 'rxjs';
import { Headers  } from '@angular/http';

import {Taxpayer} from './taxpayer.model';
import {INCOMETAX_API} from '../app.api';

@Injectable()

export class TaxpayerService {

  constructor(private http: HttpClient) { }

  getTaxpayers(): Observable<Taxpayer>{
  	return this.http.get<Taxpayer>('http://localhost:2000/v1/tax-payer')
  }

  getTaxpayerByID(id): Observable<Taxpayer>{
  	return this.http.get<Taxpayer>('http://localhost:2000/v1/tax-payer/'+id)
  }

  postTaxpayers(taxpayer: Taxpayer): Observable<Taxpayer>{
  	return this.http.post<Taxpayer>('http://localhost:2000/v1/tax-payer', taxpayer)
  }	  
}
