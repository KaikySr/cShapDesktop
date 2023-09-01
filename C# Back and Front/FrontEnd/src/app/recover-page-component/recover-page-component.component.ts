import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router'; // Adicionamos o Router aqui

@Component({
  selector: 'app-recover-page-component',
  templateUrl: './recover-page-component.component.html',
  styleUrls: ['./recover-page-component.component.css']
})

export class RecoverPageComponentComponent implements OnInit, OnDestroy {
  email = "";
  subscription: any;

  constructor(private route: ActivatedRoute, private router: Router) { } // E aqui

  ngOnInit() {
    this.subscription = this.route.params.subscribe(params => {
      this.email = params['email'];
    });
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  send() {
    // Send Email Here
    this.router.navigate(["/login"]) // E usamos para redirecionar aqui
  }
}