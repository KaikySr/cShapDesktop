import { Component } from '@angular/core';

@Component({
  selector: 'app-cpf-validator',
  templateUrl: './cpf-validator.component.html',
  styleUrls: ['./cpf-validator.component.css']
})
export class CpfValidatorComponent 
{
  protected cpf = "";
  protected print = "";
  
  protected CpfValido()
  {
    var temp = 10;
    var temp2 = 11;
    var result = 0;
    
    for (let index = 0; index < this.cpf.length; index++) 
    {
      Number(this.cpf[0]) * temp;
      temp--;
      
    }
    return result
  }

  protected cpfValido = "";

  protected Validar() 
  {
    if (this.cpf == this.cpfValido)
      this.print = "CPF válido";
    else
      this.print = "CPF inválido";

    this.cpf = "";
  }

}
