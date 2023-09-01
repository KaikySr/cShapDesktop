import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ComunityPageComponentComponent } from './comunity-page-component/comunity-page-component.component';
import { FeedPageComponentComponent } from './feed-page-component/feed-page-component.component';
import { HomePageComponentComponent } from './home-page-component/home-page-component.component';
import { LoginPageComponentComponent } from './login-page-component/login-page-component.component';
import { NewAccountPageComponentComponent } from './new-account-page-component/new-account-page-component.component';
import { NotFoundPageComponentComponent } from './not-found-page-component/not-found-page-component.component';
import { RecoverPageComponentComponent } from './recover-page-component/recover-page-component.component';
import { UserPageComponentComponent } from './user-page-component/user-page-component.component';
import { CpfValidatorComponent } from './cpf-validator/cpf-validator.component';

const routes: Routes = [
  { path: "", title: "Rede Social Minimalista", component: HomePageComponentComponent },
  {
    path: "login",
    title: "Autentificação",
    component: LoginPageComponentComponent,
    children: [ 
    { path: "newaccount", component: NewAccountPageComponentComponent }
    ]
  },
  { path: "feed", title: "Feed", component: FeedPageComponentComponent },
  { path: "comunity", title: "Comunidades", component: ComunityPageComponentComponent},
  { path: "newaccount", component: NewAccountPageComponentComponent },
  { path: "recover/:email", title: "Recuperar Senha", component: RecoverPageComponentComponent },
  { path: "recover", component: RecoverPageComponentComponent },
  { path: "user", component: UserPageComponentComponent },
  { path: "validator", component: CpfValidatorComponent },
  { path: "**", component: NotFoundPageComponentComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
