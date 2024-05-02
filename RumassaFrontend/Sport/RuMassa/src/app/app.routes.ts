import { Routes } from '@angular/router';
import { HomeComponent } from './components/pages/home/home.component';
import { NotFound404Component } from './components/pages/not-found404/not-found404.component';

export const routes: Routes = [
    { path:'', component:HomeComponent },
    { path:'**', component:NotFound404Component }
];
