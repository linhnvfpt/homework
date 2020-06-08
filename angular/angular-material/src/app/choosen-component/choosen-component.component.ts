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
    @Inject(MAT_DIALOG_DATA) public dat: data_state_checkbox
  ) {}

  ngOnInit(): void {
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
      if (comp === 'R') { 
        this.dat.full_R = true;
      }
      else if (comp === 'O') {
        this.dat.full_O = true;
      }
      else if (comp === 'C') { 
        this.dat.full_C = true;
      }
      else if (comp === 'S') {
        this.dat.full_S = true;
      }
      else {
        this.dat.full_T = true;
      }
    } else {
      if (comp === 'R') { 
        this.dat.full_R = false;
        this.dat.undefine_R = false;
      }
      else if (comp === 'O') { 
        this.dat.full_O = false;
        this.dat.undefine_O = false;
      }
      else if (comp === 'C') { 
        this.dat.full_C = false;
        this.dat.undefine_C = false;
      }
      else if (comp === 'S') {
         this.dat.full_S = false;
         this.dat.undefine_S = false;
      }
      else {
        this.dat.full_T = false;
        this.dat.undefine_T = false;
      }
    }
  }
}
