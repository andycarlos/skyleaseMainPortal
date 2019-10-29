import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Location } from '@angular/common';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TrackingService {

   URL_API = '';
    constructor(private http: HttpClient,
        location: Location) {
       
       this.URL_API = (location as any)._platformLocation._doc.baseURI + "api/traking";
   }

    getTracking(track: string): Observable<Tracking> {
        let params = new HttpParams().set("trak", track)
        return this.http.get <Tracking>(this.URL_API, { params: params });
  }

}
export interface Tracking {
    name: string;
    origin: string;
    destination: string;
    cargoType: string;
    pieces: string;
    weight: string;
    volumen: string;
    trakingHistors: TrakingHistor[];  
}
interface TrakingHistor {
    date: Date;
    Pieces: string;
    Weight: string;
    Note: string;
}
