import { Component, OnInit, Inject } from '@angular/core';
import {
  MatDialogConfig,
  MatDialogRef,
  MAT_DIALOG_DATA,
} from '@angular/material/dialog';
import { MatCheckboxChange } from '@angular/material/checkbox';
import { data_state_checkbox } from '../data_state_checkbox';

@Component({
  selector: 'app-choosen-component',
  templateUrl: './choosen-component.component.html',
  styleUrls: ['./choosen-component.component.css'],
})
export class ChoosenComponentComponent implements OnInit {

  constructor(
    public dialogRef: MatDialogRef<ChoosenComponentComponent>,
    @Inject(MAT_DIALOG_DATA) public data: data_state_checkbox
  ) {}

  ngOnInit(): void {
    console.log("Ben dialog", this.data);
    let element = document.querySelector('#cellSelected');
    const rect: DOMRect = element.getBoundingClientRect();

    const matDialogConfig = new MatDialogConfig();
    matDialogConfig.position = {
      top: (rect.bottom - 20).toString() + 'px',
      left: (rect.right - 20).toString() + 'px',
    };
    this.dialogRef.updatePosition(matDialogConfig.position);
  }

  public switchStatus(event: MatCheckboxChange, comp: string) {
    if (event.checked) {
      if (comp === 'R') this.data.full_R = true;
      else if (comp === 'O') this.data.full_O = true;
      else if (comp === 'C') this.data.full_C = true;
      else this.data.full_S = true;
    } else {
      if (comp === 'R') this.data.full_R = false;
      else if (comp === 'O') this.data.full_O = false;
      else if (comp === 'C') this.data.full_C = false;
      else this.data.full_S = false;
    }
  }
}
