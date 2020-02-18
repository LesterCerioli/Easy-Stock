import { Component } from '@angular/core';

@Component({
  selector: 'app-cadastro-component',
  templateUrl: './cadastro.component.html'
})
export class CadastroComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
