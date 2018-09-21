import { Component, OnInit } from '@angular/core';
import { Taxpayer } from '../taxpayer/taxpayer.model';
import { MinimumWage } from './minimum-wage.model';
import { MinimumWageService } from './minimum-wage.service';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-minimum-wage',
  templateUrl: './minimum-wage.component.html'
})
export class MinimumWageComponent implements OnInit {

  taxpayer: Taxpayer;
  minimums: Array<MinimumWage> = [];
  currentMinimum: MinimumWage = new MinimumWage();
 
  constructor(private data: MinimumWageService, private route: ActivatedRoute) { 
	this.route.params.subscribe(params => this.taxpayer = params.taxpayerId )
  }

  ngOnInit() {}

  addMinimumWade() {
     this.data
    .postMinimum(this.currentMinimum, this.taxpayer)
    .subscribe(minimum => {
      if (!this.currentMinimum.id) {
        this.minimums.push(minimum);
      }
      //this.currentMinimum = new MinimumWage();
    });
  }
}