import { Component} from '@angular/core';
import { RouterLink } from '@angular/router';
import { ImageModule } from 'primeng/image';

import { ToolbarModule } from 'primeng/toolbar';


@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [ImageModule, ToolbarModule, RouterLink],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss'
})
export class NavbarComponent{

}
