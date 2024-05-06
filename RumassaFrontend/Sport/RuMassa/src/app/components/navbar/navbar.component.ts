import { Component, OnInit } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { ImageModule } from 'primeng/image';
import { ToolbarModule } from 'primeng/toolbar';
import { NavbarServiceService } from './navbar-service.service';
import { categoryModel } from '../../interfaces/categoryModel';
import { AuthService } from '../../services/auth.service';


@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [ImageModule, ToolbarModule, RouterModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss'
})
export class NavbarComponent implements OnInit {

  checker = false;
  constructor(private navbarService: NavbarServiceService, private readonly authService: AuthService, private router: Router) { }
  ngOnInit(): void {
    this.getAll()
    this.check()
  }
  categories !: categoryModel[]

  getAll() {
    this.navbarService.getAllCategories().subscribe(
      (data) => {
        this.categories = data;
      }
    )
  }
  check() {
    if (this.authService.isAuthorized() === true) {
      this.checker = true;
    }
    else {
      this.checker = false;
    }
  }
  logout()
  {
    this.authService.logOut();
    this.router.navigateByUrl('/login', { skipLocationChange: true }).then(() => {
      this.router.navigate(['/login']); // Navigate to the login page
      setTimeout(() => {
        window.location.reload(); // Refresh the page after a short delay
      }, 50); // Adjust the delay as needed
    });
  }


}
