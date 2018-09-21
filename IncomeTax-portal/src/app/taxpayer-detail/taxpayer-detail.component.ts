import { Component, OnInit } from '@angular/core';
import { Taxpayer } from '../taxpayer/taxpayer.model';
import { TaxpayerService } from '../taxpayer/taxpayer.service';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-taxpayer-detail',
  templateUrl: './taxpayer-detail.component.html'
})
export class TaxpayerDetailComponent implements OnInit {

  taxpayer: Taxpayer;

  constructor(private data: TaxpayerService, private route: ActivatedRoute) { 
  	this.route.params.subscribe(params => this.taxpayer = params.id )
  }

  ngOnInit() {
  	this.data.getTaxpayerByID(this.taxpayer).subscribe(
  		taxpayer => this.taxpayer = taxpayer
  	)
  }
}

