import { Component } from '@angular/core';
import { SubscribeComponent } from '../../subscribe/subscribe.component';
import { HomeTopComponent } from './home-top/home-top.component';
import { CardComponent } from '../card/card.component';
import { VoprosiComponent } from '../voprosi/voprosi.component';
@Component({
  selector: 'app-home',
  standalone: true,
  imports: [SubscribeComponent, HomeTopComponent, CardComponent, VoprosiComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

}
