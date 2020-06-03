import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-cart-header',
  templateUrl: './cart-header.component.html',
})
export class CartHeaderComponent implements OnInit {
  title = 'Shopping Sample';
  @Input() numberItems: number;

  constructor() {}

  ngOnInit(): void {}
}
