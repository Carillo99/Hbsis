import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

import {MinimumWage} from './minimum-wage.model';
import {INCOMETAX_API} from '../app.api';

@Injectable({
  providedIn: 'root'
})
export class MinimumWageService {

  constructor(private http: HttpClient) { }

  postMinimum(minimum: MinimumWage, taxpayerId): Observable<MinimumWage>{
  	return this.http.post<MinimumWage>('http://localhost:2000/v1/tax-payer/'+taxpayerId+'/minimum-wage', minimum)
  }	  
}