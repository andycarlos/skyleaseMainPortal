import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TrackingService, Tracking } from '../../services/tracking.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  contact: FormGroup;
    tracking: string = "57650272784";
    openModal: boolean = false;
    track: Tracking;
    timerAmimation: number = 2.3;
  constructor(private formBuilder: FormBuilder,
        private trackingService: TrackingService) { }

  ngOnInit() {

    this.contact = this.formBuilder.group({
      name: ['', Validators.required],
      email: ['', Validators.required],
      comments: ['', Validators.required]
    });
  }

    GetTracking() {
        
        this.track = null;
        this.trackingService.getTracking(this.tracking).subscribe(valor => {
           this.openModal = true; 
            this.track = valor;
        });
    }
    close() {
        this.openModal = false;
    }
}
