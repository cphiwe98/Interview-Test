import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  readonly apiUrl='http://localhost:4201/api/heroes';
  constructor(private http: HttpClient) { }

  getHeroes():Observable<any[]>{
    return this.http.get<any>(this.apiUrl);
  }

  addHero(val:any){
    return this.http.post(this.apiUrl+'/Post',val);
  }
}
