import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TrackingService } from 'src/app/services/tracking.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  contact: FormGroup;
  tracking: string;

  constructor(private formBuilder: FormBuilder,
              private trackingService: TrackingService) { }

  ngOnInit() {

    this.contact = this.formBuilder.group({
      name: ['', Validators.required],
      email: ['', Validators.required],
      comments: ['', Validators.required]
    });
  }
  GetTracking(){
    this.trackingService.getTracking(this.tracking).subscribe(valor => {
      console.log(valor);
    });
  }
}
