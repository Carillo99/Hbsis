import { Taxpayer } from '../taxpayer/taxpayer.model';

export class MinimumWage {
  id: number;
  minimumWageBase: number;
  taxpayerId: number;
  taxpayer?: Taxpayer;
}