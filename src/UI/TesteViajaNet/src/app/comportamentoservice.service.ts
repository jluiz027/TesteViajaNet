import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comportamento } from 'src/model/Comportamento';

@Injectable({
  providedIn: 'root'
})
export class ComportamentoService {

  constructor(private httpclient:HttpClient) { }

  salvarComportamento(comportamento:Comportamento){
    this.httpclient.post<Comportamento>("https://localhost:5001/api/Comportamento/Salvar",comportamento)
    .subscribe(
      x => console.log(x)
    )
  }
}
