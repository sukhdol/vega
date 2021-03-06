﻿import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable()
export class VehicleService {
  constructor(private http: HttpClient) {

  }

  getMakes() {
    return this.http.get('/api/makes').pipe(map((data: any) => data));
  }

  getFeatures() {
    return this.http.get('/api/features').pipe(map((data: any) => data));
  }
}
