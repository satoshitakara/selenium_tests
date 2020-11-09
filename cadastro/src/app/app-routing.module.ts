import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BabysitterFormComponent } from './forms/babysitter-form/babysitter-form.component';
import { HomeComponent } from './home/home.component';


const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'babysitter', component: BabysitterFormComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
