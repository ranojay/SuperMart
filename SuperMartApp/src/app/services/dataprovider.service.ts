import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface Product {
  pid:string;
  name: string;
  price: number;
}
@Injectable({
  providedIn: 'root'
})
export class DataproviderService {
  constructor(private httpClient:HttpClient) { }

  getAllProducts(): Observable<Product[]> {
    return this.httpClient.get<Product[]>('http://localhost:5041/api/Products');
  }

}
