import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { PortalComponent } from './components/portal/portal.component';
import { HomeComponent } from './components/home/home.component';
import { SalesComponent } from './modules/sales/sales/sales.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'portal', component: PortalComponent,
  children: [
    { path: 'home', component: HomeComponent },
    { path: 'sales', component: SalesComponent },
    { path: '', redirectTo: '/portal/home', pathMatch: 'full' },

  ]},
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
