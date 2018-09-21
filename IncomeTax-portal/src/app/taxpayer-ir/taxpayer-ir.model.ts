import { Taxpayer } from '../taxpayer/taxpayer.model';

export class TaxpayerIR {
  id: number;
  ir: number;
  taxpayerId: number;
  taxpayer?: Taxpayer;
}