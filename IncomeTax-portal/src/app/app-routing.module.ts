import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { MinimumWageComponent } from './minimum-wage/minimum-wage.component';
import { TaxpayerComponent } from './taxpayer/taxpayer.component';
import { TaxpayerCreateComponent } from './taxpayer-create/taxpayer-create.component';
import { TaxpayerDetailComponent } from './taxpayer-detail/taxpayer-detail.component';

const routes: Routes = [
	{path: '', component: TaxpayerComponent},
	{path: 'create', component: TaxpayerCreateComponent},
	{path: 'detail/:id', component: TaxpayerDetailComponent},
	{path: 'create/:taxpayerId/minimum-wade', component: MinimumWageComponent}
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
}) 

export class AppRoutingModule{}