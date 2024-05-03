import { Component } from '@angular/core';
import { SubscribeComponent } from '../../subscribe/subscribe.component';
import { HomeTopComponent } from './home-top/home-top.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [SubscribeComponent, HomeTopComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

}
