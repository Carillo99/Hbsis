
import { Component, OnInit } from '@angular/core';
import { Taxpayer } from '../taxpayer/taxpayer.model';
import { TaxpayerService} from '../taxpayer/taxpayer.service';
import { Observable } from 'rxjs';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-taxpayer-create',
  templateUrl: './taxpayer-create.component.html'
})
export class TaxpayerCreateComponent implements OnInit {

  taxpayers: Array<Taxpayer> = [];
  currentTaxpayer: Taxpayer = new Taxpayer();
  
  constructor(private data: TaxpayerService, private router: Router) { }

  ngOnInit() {
  
  }

  addTaxpayer() {
     this.data
    .postTaxpayers(this.currentTaxpayer)
    .subscribe(taxpayer => {
      if (!this.currentTaxpayer.id) {
        this.taxpayers.push(taxpayer);
      }
      this.router.navigate(['/create/'+taxpayer.id+'/minimum-wade']);
    });
  }


}
