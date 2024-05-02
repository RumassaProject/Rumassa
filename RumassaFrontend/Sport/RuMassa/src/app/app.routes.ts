import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { HomeComponent } from './components/pages/home/home.component';
import { NotFound404Component } from './components/pages/not-found404/not-found404.component';
import { ObmeniComponent } from './components/pages/obmeni/obmeni.component';
import { OplataComponent } from './components/pages/oplata/oplata.component';

export const routes: Routes = [
    {path:'', redirectTo: '/home', pathMatch: 'full'},
    {path:'home', component:HomeComponent},
    {path:'oplata', component:OplataComponent},
    {path:'obmeni', component:ObmeniComponent},
    {path:'**', component:NotFound404Component}
];
