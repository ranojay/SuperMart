import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { DataproviderService, Product } from 'src/app/services/dataprovider.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: [
  ]
})
export class HomeComponent implements OnInit {

  products$ : Observable<Product[]> | undefined;
  
  constructor(private dataProvider:DataproviderService) { }

  ngOnInit(): void {
    this.products$ = this.dataProvider.getAllProducts();
  }

}
