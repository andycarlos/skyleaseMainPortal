import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {

  constructor() { }
  ngOnInit() {
  }
  hover(targe:HTMLParagraphElement)
  {
    targe.classList.add("show");

  }
  leave(targe:HTMLParagraphElement){
    targe.classList.remove("show");
  }
}
