import { TaxpayerIR } from '../taxpayer-ir/taxpayer-ir.model';
import { MinimumWage } from '../minimum-wage/minimum-wage.model';

export class Taxpayer {
  id: number;
  cpf: string;
  name: string;
  numberDependents: number;
  grossIncome: number;
  taxpayerIR: TaxpayerIR;
  minimumWage: MinimumWage;
}