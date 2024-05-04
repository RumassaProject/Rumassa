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
import { ContactsComponent } from './components/contacts/contacts.component';
import { CpaciboComponent } from './components/pages/cpacibo/cpacibo.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { ConsultationComponent } from './components/pages/consultation/consultation.component';
import { VkladkiComponent } from './components/pages/vkladki/vkladki.component';

export const routes: Routes = [
    {path:'', redirectTo: '/home', pathMatch: 'full'},
    {path:'home', component:HomeComponent},
    {path:'oplata', component:OplataComponent},
    {path:'obmeni', component:ObmeniComponent},
    {path:'skidki', component:SkidkiComponent},
    {path:'dostavka', component:DostavkaComponent},
    {path:'login', component:LoginComponent},
    {path:'register', component:RegistrationComponent},
    {path:'dashboard', component: DashboardComponent},
    {path:'kakoformit', component:KakoformitComponent},
    {path:'contacts', component:ContactsComponent},
    {path:'cpacibo', component:CpaciboComponent},
    {path:'consultation', component:ConsultationComponent},
    {path:'vkladki', component:VkladkiComponent},

    {path:'**', component:NotFound404Component}

];
