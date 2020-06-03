import { Component, OnInit, Input } from '@angular/core';
import { CartSummary } from '../cart-summary.model';

@Component({
  selector: 'app-cart-summary',
  templateUrl: './cart-summary.component.html',
})
export class CartSummaryComponent implements OnInit {
  @Input() cart_summary:CartSummary;
  constructor() {}
  ngOnInit(): void {}
}
