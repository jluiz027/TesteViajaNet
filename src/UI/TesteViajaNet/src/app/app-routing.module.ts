import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TesteviajanetComponent } from './testeviajanet/testeviajanet.component';
import { HomeComponent } from './home/home.component';
import { CheckoutComponent } from './checkout/checkout.component';


const routes: Routes = [
  { path: 'viajanet', component: TesteviajanetComponent },
  { path: 'home', component: HomeComponent },
  { path: 'checkout', component: CheckoutComponent },
  { path: '**', component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
