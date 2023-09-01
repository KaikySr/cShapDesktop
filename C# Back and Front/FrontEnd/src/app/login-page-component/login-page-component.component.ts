import { Component } from '@angular/core';
import { Router } from '@angular/router';


@Component(
{
  selector: 'app-login-page-component',
  templateUrl: './login-page-component.component.html',
  styleUrls: ['./login-page-component.component.css'],
})

export class LoginPageComponentComponent 
{
  email = ""
  link = ""
  password = ""

  constructor(private router: Router) { }

  passwordChanged(event: any)
  {
    this.password = event
  }

  login() 
  {
    // Aqui precisariamos fazer essa verificação no banco de dados
    if (this.email == "don@platinado.com" && this.password == "123") {
      // Isso evidentemente não é seguro, mas a ideia é bom e será melhorada no futuro
      sessionStorage.setItem('user', 'donplatinado');
      this.router.navigate(["/feed"])
    }
  }
}
