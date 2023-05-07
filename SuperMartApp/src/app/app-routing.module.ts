import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { PortalComponent } from './components/portal/portal.component';
import { HomeComponent } from './components/home/home.component';
import { SalesComponent } from './modules/sales/sales/sales.component';
import { AuthGuard } from './guards/auth.guard';
import { NotfoundComponent } from './components/notfound/notfound.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'portal', component: PortalComponent,
  canActivate: [AuthGuard],
  children: [
    { path: 'home', component: HomeComponent },
    { path: 'sales', component: SalesComponent },
    { path: '', redirectTo: '/portal/home', pathMatch: 'full' },
  ]},
  { path: '**', component: NotfoundComponent },
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
