import { Component, OnInit } from '@angular/core';
import {Taxpayer} from './taxpayer.model';
import {TaxpayerService} from './taxpayer.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-taxpayer',
  templateUrl: './taxpayer.component.html'
})
export class TaxpayerComponent implements OnInit {

 incomeTax$: Taxpayer;

  constructor(private data: TaxpayerService) { }

  ngOnInit() {
  	this.data.getTaxpayers().subscribe(
  		data => this.incomeTax$ = data
  	)
  }

  
}
