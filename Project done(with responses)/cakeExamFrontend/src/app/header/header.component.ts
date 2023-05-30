import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserAuthService } from 'src/services/user-auth.service';
import { UserServiceService } from 'src/services/user-service.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private userAuth:UserAuthService,
    private router:Router,
    public userService: UserServiceService) {
      window.onload = () => {
        const menBtn = document.getElementById('menu-btn') as HTMLButtonElement;
        const navbar = document.getElementById('navbar') as HTMLElement;
        const menu = document.querySelector('.menu') as HTMLElement;
     
        const offset = 50;
     
        menBtn.addEventListener('click', () => {
            menu.classList.toggle('menu-open');
        });
     
        window.addEventListener("scroll", () => {
            if (window.scrollY > offset) {
                navbar.classList.add('navbar-active');
            } else {
                navbar.classList.remove('navbar-active');
            }
        });
     }
    }

  ngOnInit(): void {
  }

  public isLoggedIn(){
    return this.userAuth.isLoggedIn();
  }
  public logout(){
    this.userAuth.clear();
    this.router.navigate(['mainPage'])
  }

}
