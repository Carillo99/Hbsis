import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { TaxpayerService } from './taxpayer/taxpayer.service';
import { MinimumWageService } from './minimum-wage/minimum-wage.service';


import { HttpClientModule } from '@angular/common/http';
import { TaxpayerIrComponent } from './taxpayer-ir/taxpayer-ir.component';
import { MinimumWageComponent } from './minimum-wage/minimum-wage.component';
import { TaxpayerComponent } from './taxpayer/taxpayer.component';
import { TaxpayerCreateComponent } from './taxpayer-create/taxpayer-create.component';
import { TaxpayerDetailComponent } from './taxpayer-detail/taxpayer-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    TaxpayerIrComponent,
    MinimumWageComponent,
    TaxpayerComponent,
    TaxpayerCreateComponent,
    TaxpayerDetailComponent,
  ],
  imports: [ 
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [TaxpayerService, MinimumWageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
