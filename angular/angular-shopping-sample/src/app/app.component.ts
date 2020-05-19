import { Component, OnInit } from '@angular/core';
import { Product } from './product.model';
import { CartSummary } from './cart-summary.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent implements OnInit {
  products: Product[] = [
    {
      id: '1',
      name: 'iPhone 8 Plus 64GB',
      description: 'Camera kép chuyên nghiệp',
      thumbnail: '/assets/item1.JPG',
      price: 5.99,
      quantity: 3,
    },
    {
      id: '2',
      name: 'Samsung Galaxy S20+',
      description: 'Thiết kế màn hình tràn viền, siêu mượt 120 Hz',
      thumbnail: '/assets/item2.JPG',
      price: 9.99,
      quantity: 1,
    },
    {
      id: '3',
      name: 'Samsung Galaxy A7',
      description: 'Thiết kế màn hình tràn viền, siêu mượt 120 Hz',
      thumbnail: '/assets/item2.JPG',
      price: 10.99,
      quantity: 1,
    },
  ];

  numberItems: number = 0;
  cartSummary: CartSummary = new CartSummary();

  constructor() {}

  ngOnInit(): void {
    for (const product of this.products) {
      console.log(product.price, product.quantity);
      this.cartSummary.subtotal += product.price * product.quantity;
    }
    
    this.cartSummary.tax = 0.01 * this.cartSummary.subtotal;
    this.cartSummary.total = this.cartSummary.subtotal + this.cartSummary.tax;
    console.log(this.cartSummary.subtotal, this.cartSummary.tax, this.cartSummary.total);
  }

  removeProduct(productId: string) {
    const index = this.products.findIndex(
      (product) => product.id === productId
    );
    if (index != -1) this.products.splice(index, 1);

    // Re-calculate number items and sub total
    let numberItems = 0;
    let subTotal = 0;

    for (const product of this.products) {
      numberItems += product.quantity;
      subTotal += product.price * product.quantity;
    }

    this.numberItems = numberItems;
    this.cartSummary.subtotal = subTotal;
  }
}
