import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { HomeComponent } from './components/pages/home/home.component';
import { NotFound404Component } from './components/pages/not-found404/not-found404.component';
import { ObmeniComponent } from './components/pages/obmeni/obmeni.component';
import { OplataComponent } from './components/pages/oplata/oplata.component';
import { SkidkiComponent } from './components/pages/skidki/skidki.component';
import { DostavkaComponent } from './components/pages/dostavka/dostavka.component';
import { LoginComponent } from './components/login/login.component';
import { KakoformitComponent } from './components/pages/kakoformit/kakoformit.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { CpaciboComponent } from './components/pages/cpacibo/cpacibo.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AdresdostavkiComponent } from './components/pages/adresdostavki/adresdostavki.component';

export const routes: Routes = [
    {path:'', redirectTo: '/home', pathMatch: 'full'},
    {path:'home', component: HomeComponent},
    {path:'dashboard', component: DashboardComponent},
    {path:'oplata', component: OplataComponent},
    {path:'obmeni', component: ObmeniComponent},
    {path:'skidki', component: SkidkiComponent},
    {path:'dostavka', component: DostavkaComponent},
    {path:'login', component: LoginComponent},
    {path:'register', component: RegistrationComponent},
    {path:'adresdostavki', component: AdresdostavkiComponent},

    {path:'kakoformit', component:KakoformitComponent},
    {path:'cpacibo', component:CpaciboComponent},

    {path:'**', component:NotFound404Component}

];
