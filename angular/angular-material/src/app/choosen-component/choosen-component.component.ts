import { Component, OnInit, Inject } from '@angular/core';
import {
  MatDialogConfig,
  MatDialogRef,
  MAT_DIALOG_DATA,
} from '@angular/material/dialog';
import { MatCheckboxChange } from '@angular/material/checkbox';

export interface DialogData {
  cell_content: string;
}

@Component({
  selector: 'app-choosen-component',
  templateUrl: './choosen-component.component.html',
  styleUrls: ['./choosen-component.component.css'],
})
export class ChoosenComponentComponent implements OnInit {
  reduceSelected: boolean = false;
  oletSelected: boolean = false;
  couplingSelected: boolean = false;
  stubSelected: boolean = false;

  constructor(
    public dialogRef: MatDialogRef<ChoosenComponentComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData
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

    let arrayCompSelected = this.data.cell_content.split(',');
    if (arrayCompSelected.indexOf('R') > -1) {
      this.reduceSelected = true;
    }
    else this.reduceSelected = false;

    if (arrayCompSelected.indexOf('O') > -1) {
      this.oletSelected = true;
    }
    else this.oletSelected = false;

    if (arrayCompSelected.indexOf('C') > -1) {
      this.couplingSelected = true;
    }
    else this.couplingSelected = false;

    if (arrayCompSelected.indexOf('S') > -1) {
      this.stubSelected = true;
    }
    else this.stubSelected = false;
  }

  public switchStatus(event: MatCheckboxChange, comp: string) {
    this.data.cell_content = '';
    if (event.checked) {
      if (comp === 'R') this.reduceSelected = true;
      else if (comp === 'O') this.oletSelected = true;
      else if (comp === 'C') this.couplingSelected = true;
      else this.stubSelected = true;
    } else {
      if (comp === 'R') this.reduceSelected = false;
      else if (comp === 'O') this.oletSelected = false;
      else if (comp === 'C') this.couplingSelected = false;
      else this.stubSelected = false;
    }

    if (this.reduceSelected) {
      this.data.cell_content += 'R,';
    }

    if (this.oletSelected) {
      this.data.cell_content += 'O,';
    }

    if (this.couplingSelected) {
      this.data.cell_content += 'C,';
    }

    if (this.stubSelected) {
      this.data.cell_content += 'S,';
    }

    this.data.cell_content = this.data.cell_content.slice(0, this.data.cell_content.length);
  }
}
