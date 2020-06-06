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
  isR = false;
  isO = false;
  isC = false;
  isS = false;

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
    this.isR = this.dat.full_R;
    this.isO = this.dat.full_O;
    this.isC = this.dat.full_C;
    this.isS = this.dat.full_S;
  }

  public switchStatus(event: MatCheckboxChange, comp: string) {
    if (event.checked) {
      if (comp === 'R') { 
        this.dat.full_R = true;
        this.isR = true;
      }
      else if (comp === 'O') {
        this.dat.full_O = true;
        this.isO = true;
      }
      else if (comp === 'C') { 
        this.dat.full_C = true;
        this.isC = true;
      }
      else {
        this.dat.full_S = true;
        this.isS = true;
      }
    } else {
      if (comp === 'R') { 
        this.dat.full_R = false;
        this.dat.undefine_R = false;
        this.isR = false;
      }
      else if (comp === 'O') { 
        this.dat.full_O = false;
        this.dat.undefine_O = false;
        this.isO = false;
      }
      else if (comp === 'C') { 
        this.dat.full_C = false;
        this.dat.undefine_C = false;
        this.isC = false;
      }
      else {
         this.dat.full_S = false;
         this.dat.undefine_S = false;
         this.isS = false;
      }
    }
  }
}
