import { HttpClient } from "@angular/common/http";
import { inject } from "@angular/core";
import { Injectable } from "@angular/core";

export type RendimentoRequest = {
  valor: number;
  meses: number;
};

export type RendimentoResponse = {
  totalBruto: number;
  totalLiquido: number;
  rendimentoBruto: number;
  rendimentoLiquido: number;
  deducoes: number;
};

@Injectable({
  providedIn: "root",
})
export class AppService {
  http = inject(HttpClient);
  private readonly url = "https://localhost:5001";

  calcular$ = (request: RendimentoRequest) =>
    this.http.post<RendimentoResponse>(`${this.url}/calcular`, request);
}
