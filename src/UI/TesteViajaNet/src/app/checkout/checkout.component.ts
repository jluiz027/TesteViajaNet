import { Component, OnInit } from '@angular/core';
import { ComportamentoService } from '../comportamentoservice.service';
import { Comportamento } from 'src/model/Comportamento';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {

  constructor(private comportamentoservice:ComportamentoService) { }

  ngOnInit() {
    let comportamento = new Comportamento();
    comportamento.NomePagina = "Chekout";
    comportamento.Id="";
    comportamento.Browser = window.navigator.userAgent;
    comportamento.IP;
    
    this.comportamentoservice.salvarComportamento(comportamento);
    //alert(userAgent);
    //console.log(userAgent);
  }

}
