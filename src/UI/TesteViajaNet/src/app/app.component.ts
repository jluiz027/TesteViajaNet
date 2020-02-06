import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TesteViajaNet';

  constructor(private router: Router) {}

  navigateToLogin() {
    console.log("teste");
    this.router.navigateByUrl('/home');
 }
}
