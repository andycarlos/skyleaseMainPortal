import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TrackingService {

  readonly URL_API = 'http://skylease.cargolink.aero/tracking/index.asp?awbno=';

  constructor(private http: HttpClient) {
   }

  getTracking(track: string) {
    let httpHeaders = new HttpHeaders();
    httpHeaders = httpHeaders.set('Accept', '*/*');
    return this.http.get(this.URL_API + track, {responseType: 'text', headers: httpHeaders});
  }

}
