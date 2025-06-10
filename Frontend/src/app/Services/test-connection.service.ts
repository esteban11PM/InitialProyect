import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { GenericService } from './generic.service';
import { Test } from '../Models/Test.model';
import { environment } from '../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class TestConnectionService extends GenericService<Test> {
  constructor(http:HttpClient){
    const baseURL = environment.apiURL + 'WeatherForecast/'
    super(http, baseURL)
  }
}
