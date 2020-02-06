import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TesteviajanetComponent } from './testeviajanet/testeviajanet.component';


const routes: Routes = [
  { path: 'viajanet', component: TesteviajanetComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
