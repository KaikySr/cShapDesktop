import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { ComunityPageComponentComponent } from './comunity-page-component/comunity-page-component.component';
import { FeedPageComponentComponent } from './feed-page-component/feed-page-component.component';
import { HomePageComponentComponent } from './home-page-component/home-page-component.component';
import { LoginPageComponentComponent } from './login-page-component/login-page-component.component';
import { NewAccountPageComponentComponent } from './new-account-page-component/new-account-page-component.component';
import { NotFoundPageComponentComponent } from './not-found-page-component/not-found-page-component.component';
import { RecoverPageComponentComponent } from './recover-page-component/recover-page-component.component';
import { UserPageComponentComponent } from './user-page-component/user-page-component.component';
import { PasswordComponent } from './password/password.component';
import { FormsModule } from '@angular/forms';
import { CreatePasswordComponent } from './create-password/create-password.component';
import { CpfValidatorComponent } from './cpf-validator/cpf-validator.component'; // Adicionado para poder usar o ngModel
import { HttpClientModule } from '@angular/common/http'; // Added for use HttpClient
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; // Added for use ReactiveForms
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatButtonModule } from '@angular/material/button'; // Added for use Angular Material Button
import { MatCardModule } from '@angular/material/card';

@NgModule({
  declarations:
  [
    AppComponent,
    NavComponent,
    ComunityPageComponentComponent,
    FeedPageComponentComponent,
    HomePageComponentComponent,
    LoginPageComponentComponent,
    NewAccountPageComponentComponent,
    NotFoundPageComponentComponent,
    RecoverPageComponentComponent,
    UserPageComponentComponent,
    PasswordComponent,
    CreatePasswordComponent,
    CpfValidatorComponent
  ],
  imports: 
  [
    BrowserModule,
    AppRoutingModule,
    FormsModule, // Adicionado para poder usar o ngModel
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatSlideToggleModule,
    MatButtonModule,
    MatCardModule
  ],
  providers: 
  [
    
  ],
  bootstrap: 
  [
    AppComponent
  ]
})
export class AppModule { }
