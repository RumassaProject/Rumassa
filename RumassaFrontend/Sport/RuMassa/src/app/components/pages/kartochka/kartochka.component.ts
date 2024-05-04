import { Component } from '@angular/core';

@Component({
  selector: 'app-kartochka',
  standalone: true,
  imports: [],
  templateUrl: './kartochka.component.html',
  styleUrl: './kartochka.component.scss'
})
export class KartochkaComponent {
  value=0
  c1="exit_btn1"
  c2="exit_btn2"
delete1(){
  console.log("bello")
this.c1="cc"
}
delete2(){
  this.c2="cc"

}
minus(){
  if(this.value!=0){
    this.value-=1
  }
}
plus(){
  this.value+=1
}
}
