import { Component, OnInit } from '@angular/core';
import { Comportamento } from 'src/model/Comportamento';
import { ComportamentoService } from '../comportamentoservice.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private comportamentoservice:ComportamentoService) { }

  ngOnInit() {
    let comportamento = new Comportamento();
    comportamento.NomePagina = "Home";
    comportamento.Id="";
    comportamento.Browser = window.navigator.userAgent;
    comportamento.IP;
    
    this.comportamentoservice.salvarComportamento(comportamento);
    //alert(userAgent);
    //console.log(userAgent);
  }

}
